using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;

namespace location
{
    enum Protocol
    {
        whois,
        HTTP09,
        HTTP10,
        HTTP11
    }
    struct Parameters
    {
        public string[] args;
        public string server;
        public int port;
        public int timeout;
        public string user;
        public string location;
        public Protocol protocol;
        public Parameters(string[] args, string server, int port, int timeout, string user, string location, Protocol protocol)
        {
            this.args = args;
            this.server = server;
            this.port = port;
            this.timeout = timeout;
            this.user = user;
            this.location = location;
            this.protocol = protocol;
        }
    }
    public class Whois
    {
        static void Response(StreamReader sr)
        {
            System.Threading.Thread.Sleep(1000);
            string response = null;
            while (sr.Peek() > -1)
            {
                response = sr.ReadLine();
                Console.WriteLine(response);
            }
        }
        static bool Response2(StreamReader sr, Parameters p, string check)
        {
            string response = null;

            if (sr.Peek() > -1)
            {
                response += sr.ReadLine();

                if (response == check)
                {
                    return true;
                }
            }
            else
            {
                Console.WriteLine("Error : No Response / Record Not Found");
                return false;
            }
            return false;
        }
        static void Interpreter(ref Parameters p)
        {
            try
            {
                for (int i = 0; i < p.args.Length; i++)
                {
                    switch (p.args[i])
                    {
                        case "-h":
                            p.server = p.args[++i];
                            break;
                        case "-p":
                            p.port = int.Parse(p.args[++i]);
                            break;
                        case "-t":
                            p.timeout = int.Parse(p.args[++i]);
                            break;
                        case "-h9":
                            p.protocol = Protocol.HTTP09;
                            break;
                        case "-h0":
                            p.protocol = Protocol.HTTP10;
                            break;
                        case "-h1":
                            p.protocol = Protocol.HTTP11;
                            break;

                        default:
                            if (p.user == null)
                            {
                                p.user = p.args[i];
                            }
                            else
                            {
                                p.location = p.args[i];
                            }
                            break;
                    }
                }
            }
            catch (Exception e) { Console.WriteLine("Error : " + e.Message); }
        }
        static void Main(string[] args)
        {
            try
            {
                Parameters p = new Parameters(args, "localhost", 43, 3000, null, null, Protocol.whois);

                Interpreter(ref p);

                TcpClient client = new TcpClient();
                client.Connect(p.server, p.port);
                client.ReceiveTimeout = p.timeout;
                client.SendTimeout = p.timeout;

                StreamWriter sw = new StreamWriter(client.GetStream());
                StreamReader sr = new StreamReader(client.GetStream());             

                switch (p.protocol)
                {
                    case Protocol.whois:
                        if (p.location == null)
                        {
                            sw.WriteLine(p.user);
                            sw.Flush();

                            string response = sr.ReadLine();
                            Console.WriteLine(p.user + " is " + response);
                            break;
                        }
                        else
                        {
                            sw.WriteLine(p.user + " " + p.location);
                            sw.Flush();

                            if (Response2(sr, p, "OK"))
                            {
                                Console.WriteLine(p.user + " location changed to be " + p.location);
                            }

                            break;
                        }
                    case Protocol.HTTP09:
                        if (p.location == null) //GET
                        {
                            sw.WriteLine("GET" + " /" + p.user);
                            sw.Flush();

                            //Response(sr);
                            if (Response2(sr, p, "HTTP/0.9 200 OK"))
                            {
                                sr.ReadLine();
                                sr.ReadLine();
                                p.location = sr.ReadLine();
                                Console.WriteLine(p.user + " is " + p.location);
                            }
                            break;
                        }
                        else //PUT
                        {
                            sw.WriteLine("PUT" + " /" + p.user);
                            sw.WriteLine("");
                            sw.WriteLine(p.location);
                            sw.Flush();

                            //Response(sr);
                            if(Response2(sr, p, "HTTP/0.9 200 OK"))
                            {
                                Console.WriteLine(p.user + " location changed to be " + p.location);
                            }
                            break;
                        }
                    case Protocol.HTTP10:
                        if (p.location == null) //GET
                        {
                            sw.WriteLine("GET" + " /?" + p.user + " HTTP/1.0");
                            sw.WriteLine("");
                            sw.Flush();

                            //Response(sr);
                            if (Response2(sr, p, "HTTP/1.0 200 OK"))
                            {
                                sr.ReadLine();
                                sr.ReadLine();
                                p.location = sr.ReadLine();
                                Console.WriteLine(p.user + " is " + p.location);
                            }
                            break;
                        }
                        else //POST
                        {
                            sw.WriteLine("POST" + " /" + p.user + " HTTP/1.0");
                            sw.WriteLine("Content-Length: " + p.location.Length);
                            sw.WriteLine("");
                            sw.Write(p.location);
                            sw.Flush();

                            //Response(sr);
                            if(Response2(sr, p, "HTTP/1.0 200 OK"))
                            {
                                Console.WriteLine(p.user + " location changed to be " + p.location);
                            }
                            break;
                        }
                    case Protocol.HTTP11:
                        if (p.location == null) //GET
                        {
                            sw.WriteLine("GET" + " /?name=" + p.user + " HTTP/1.1");
                            sw.WriteLine("Host: " + p.server);
                            sw.WriteLine("");
                            sw.Flush();

                            //Response(sr);
                            if (Response2(sr, p, "HTTP/1.1 200 OK"))
                            {
                                sr.ReadLine();
                                sr.ReadLine();
                                p.location = sr.ReadLine();
                                Console.WriteLine(p.user + " is " + p.location);
                            }
                            break;
                        }
                        else // POST
                        {
                            string length = ("name=" + p.user + "&location=" + p.location);

                            sw.WriteLine("POST / HTTP/1.1");
                            sw.WriteLine("Host: " + p.server);
                            sw.WriteLine("Content-Length: " + length.Length);
                            sw.WriteLine("");
                            sw.Write(length);
                            sw.Flush();

                            //Response(sr);
                            if (Response2(sr, p, "HTTP/1.1 200 OK"))
                            {                                
                                Console.WriteLine(p.user + " location changed to be " + p.location);
                            }
                            break;
                        }
                    default:
                        break;
                }
            }
            catch(SocketException)
            {
                Console.WriteLine("Error : Stream timed out");
            }

            catch(Exception e)
            {                
                Console.WriteLine("Error : " + e.Message);
            }
        }
    }
}
