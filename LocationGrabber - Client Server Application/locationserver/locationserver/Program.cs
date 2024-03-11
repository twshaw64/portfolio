using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace locationserver
{
    class Program
    {        
        static void Main(string[] args)
        {
            runServer();
        }
        static void runServer()
        {
            TcpListener listener;
            Socket connection;
            Handler requestHandler;

            Dictionary<String, String> Locations = new Dictionary<string, string>();
            Locations.Add("Jezza", "Maga");
            Locations.Add("Jerry", "Napa");
            Locations.Add("Jeremy", "Korfu");
            try
            {
                listener = new TcpListener(IPAddress.Any,43);
                listener.Start();
                Console.WriteLine("Server started listening");

                while (true)
                    {
                        connection = listener.AcceptSocket();
                        requestHandler = new Handler();
                        Thread t = new Thread (() => requestHandler.doRequest(connection, Locations) );
                        t.Start();
                    }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception : " + e);
            }
            
        }
        struct Parameters
        {
            public string[] line1;
            public string line2;
            public string line3;
            public string line4;
            public string[] line5;
            public string user;
            public string location;
            public StreamWriter sw;
            public StreamReader sr;
            public Parameters(string[] line1, string line2, string line3, string line4, string[] line5, string user, string location, StreamWriter sw, StreamReader sr)
            {
                this.line1 = line1;
                this.line2 = line2;
                this.line3 = line3;
                this.line4 = line4;
                this.line5 = line5;
                this.user = user;
                this.location = location;
                this.sw = sw;
                this.sr = sr;
            }
        }
        static void whois(ref Parameters p, ref Dictionary<string, string> Locations)
        {
            p.user = p.line1[0];

            switch (p.line1.Length > 1)
            {
                case false: //return location
                    if (Locations.ContainsKey(p.user))
                    {
                        Console.WriteLine("Request for location of " + p.user);
                        p.sw.WriteLine(Locations[p.user]);
                        p.sw.Flush();
                    }
                    else
                    {
                        Console.WriteLine("No matching entry for " + p.user);
                        p.sw.WriteLine("ERROR: no entries found");
                        p.sw.Flush();
                    }
                    break;
                case true: //change location
                    for (int i = 1; i < p.line1.Length; i++) //gets location into one string
                    {
                        p.location += p.line1[i] + " ";
                    }
                    p.location = p.location.Trim();
                    if (Locations.ContainsKey(p.user))
                    {
                        Locations[p.user] = p.location;
                        Console.WriteLine("Location of " + p.user + "changed to be " + p.location);
                        p.sw.WriteLine("OK");
                        p.sw.Flush();
                    }
                    else
                    {
                        Locations.Add(p.user, p.location);
                        Console.WriteLine("Location of " + p.user + " changed to be " + p.location);
                        p.sw.WriteLine("OK");
                        p.sw.Flush();
                    }
                    break;
            }
        }
        static void http9GET(ref Parameters p, ref Dictionary<string, string> Locations)
        {
            p.user = p.line1[1].Remove(0, 1);
            if (Locations.ContainsKey(p.user))
            {
                p.sw.WriteLine("HTTP/0.9 200 OK");
                p.sw.WriteLine("Content-Type: text/plain");
                p.sw.WriteLine("");
                p.sw.WriteLine(Locations[p.user]);
                p.sw.Flush();
            }
            else
            {
                Console.WriteLine("No matching entry for " + p.user);
                p.sw.WriteLine("HTTP/0.9 404 Not Found");
                p.sw.WriteLine("Content-Type: text/plain");
                p.sw.WriteLine("");
                p.sw.Flush();
            }
        }
        static void http9PUT(ref Parameters p, ref Dictionary<string, string> Locations)
        {
            p.user = p.line1[1].Remove(0, 1);
            if (Locations.ContainsKey(p.user))
            {
                Locations[p.user] = p.location;
                Console.WriteLine("Location of " + p.user + " changed to be " + p.location);
                p.sw.WriteLine("HTTP/0.9 200 OK");
                p.sw.WriteLine("Content-Type: text/plain");
                p.sw.WriteLine("");
                p.sw.Flush();
            }
            else
            {
                Locations.Add(p.user, p.location);
                Console.WriteLine("Location of " + p.user + " changed to be " + p.location);
                p.sw.WriteLine("HTTP/0.9 200 OK");
                p.sw.WriteLine("Content-Type: text/plain");
                p.sw.WriteLine("");
                p.sw.Flush();
            }
        }
        static void http0(ref Parameters p, ref Dictionary<string, string> Locations)
        {
            switch (p.line1[0])
            {
                case "GET":
                    {
                        p.user = p.line1[1].Remove(0, 2); //trims /?
                        if (Locations.ContainsKey(p.user))
                        {
                            p.sw.WriteLine("HTTP/1.0 200 OK");
                            p.sw.WriteLine("Content-Type: text/plain");
                            p.sw.WriteLine("");
                            p.sw.WriteLine(Locations[p.user]);
                            p.sw.Flush();
                        }
                        else
                        {
                            Console.WriteLine("No matching entry for " + p.user);
                            p.sw.WriteLine("HTTP/1.0 404 Not Found");
                            p.sw.WriteLine("Content-Type: text/plain");
                            p.sw.WriteLine("");
                            p.sw.Flush();
                        }
                        break;
                    }
                case "POST":
                    {
                        p.user = p.line1[1].TrimStart('/');
                        p.location = p.line4;
                        if (Locations.ContainsKey(p.user))
                        {
                            Locations[p.user] = p.location;
                            Console.WriteLine("Location of " + p.user + " changed to be " + p.location); //ignores flag and accounts for arrays starting at 0
                            p.sw.WriteLine("HTTP/1.0 200 OK");
                            p.sw.WriteLine("Content-Type: text/plain");
                            p.sw.WriteLine("");
                            p.sw.Flush();
                        }
                        else
                        {
                            Locations.Add(p.user, p.location);
                            Console.WriteLine("Location of " + p.user + " changed to be " + p.location); //ignores flag and accounts for arrays starting at 0
                            p.sw.WriteLine("HTTP/1.0 200 OK");
                            p.sw.WriteLine("Content-Type: text/plain");
                            p.sw.WriteLine("");
                            p.sw.Flush();
                        }
                        break;
                    }
            }
        }
        static void http1(ref Parameters p, ref Dictionary<string,string> Locations)
        {
            switch (p.line1[0])
            {
                case "GET":
                    {
                        p.user = p.line1[1].Remove(0, 7); //trims /?name=
                        if (Locations.ContainsKey(p.user))
                        {
                            p.sw.WriteLine("HTTP/1.1 200 OK");
                            p.sw.WriteLine("Content-Type: text/plain");
                            p.sw.WriteLine("");
                            p.sw.WriteLine(Locations[p.user]);
                            p.sw.Flush();
                        }
                        else
                        {
                            Console.WriteLine("No matching entry for " + p.user);
                            p.sw.WriteLine("HTTP/1.1 404 Not Found");
                            p.sw.WriteLine("Content-Type: text/plain");
                            p.sw.WriteLine("");
                            p.sw.Flush();
                        }
                        break;
                    }
                case "POST":
                    {
                        p.user = p.line5[0].Remove(0, 5); //accounts for HTTP formatting
                        p.location = p.line5[1].Remove(0, 9); //accounts for HTTP formatting
                        if (Locations.ContainsKey(p.user))
                        {
                            Locations[p.user] = p.location;
                            Console.WriteLine("Location of " + p.user + " changed to be " + p.location);
                            p.sw.WriteLine("HTTP/1.1 200 OK");
                            p.sw.WriteLine("Content-Type: text/plain");
                            p.sw.WriteLine("");
                            p.sw.Flush();
                        }
                        else
                        {
                            Locations.Add(p.user, p.location);
                            Console.WriteLine("Location of " + p.user + " changed to be " + p.location);
                            p.sw.WriteLine("HTTP/1.1 200 OK");
                            p.sw.WriteLine("Content-Type: text/plain");
                            p.sw.WriteLine("");
                            p.sw.Flush();
                        }
                        break;
                    }
            }
        }

        class Handler
        {

            public void doRequest(Socket connection, Dictionary<string, string> Locations)
            {
                NetworkStream socketStream;
                socketStream = new NetworkStream(connection);
                Console.WriteLine("Connection recieved");
                try
                {
                    Parameters p = new Parameters();

                    p.sw = new StreamWriter(socketStream);
                    p.sr = new StreamReader(socketStream);

                    string input = "";
                    var peek = p.sr.Peek(); //was using while(p.sr.Peek() != -1) but it caused issues with 1.0 and 1.1
                    while (peek != -1) //adds input to string until an empty line is read
                    {
                        input += p.sr.ReadLine().Trim();
                        input += "|";
                        peek = p.sr.Peek();
                    }
                    Console.WriteLine("Input recieved: " + input.TrimEnd('|'));
                    String[] lines = input.Split('|');

                    for (int i = 0; i < lines.Length; i++)
                    {
                        lines[i] = lines[i].TrimEnd('\n', '\r', ' '); //removing irrelevant characters
                    }

                    p.line1 = null; //used to find protocol, name and location most of the time
                    p.line2 = null;
                    p.line3 = null;
                    p.line4 = null;
                    p.line5 = null; //only HTTP 1.1

                    try
                    {
                        p.line1 = lines[0].Split(' '); // Splits protocol name and location
                        p.line2 = lines[1];
                        p.line3 = lines[2];
                        p.line4 = lines[3];
                        p.line5 = lines[4].Split('&'); //splits user and location for HTTP 1.1
                    }
                    catch { }

                    Console.WriteLine("Input recieved: " + input.TrimEnd('|'));

                    p.user = null;
                    p.location = null;

                    if (p.line1.Length > 2) // 3 or more args
                    {
                        switch (p.line1[2])
                        {
                            case "HTTP/1.0": //HTTP 1.0
                                {
                                    http0(ref p, ref Locations);
                                    break;
                                }
                            case "HTTP/1.1": // HTTP 1.1
                                {
                                    http1(ref p, ref Locations);
                                    break;
                                }
                            default:
                                {
                                    p.location = p.line3;
                                    switch (p.line1[0]) //HTTP 0.9
                                    {
                                        case "GET":
                                            {
                                                http9GET(ref p, ref Locations);
                                                break;
                                            }
                                        case "PUT":
                                            {
                                                http9PUT(ref p, ref Locations);
                                                break;
                                            }
                                        default: //whois
                                            {
                                                whois(ref p, ref Locations);
                                                break;
                                            }
                                    }
                                    break;
                                }
                        }
                    }
                    else
                    {
                        p.location = p.line3;
                        switch (p.line1[0]) //HTTP 0.9
                        {
                            case "GET":
                                {
                                    http9GET(ref p, ref Locations);
                                    break;
                                }
                            case "PUT":
                                {
                                    http9PUT(ref p, ref Locations);
                                    break;
                                }
                            default: //whois
                                {
                                    whois(ref p, ref Locations);
                                    break;
                                }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error : " + e.Message);
                }
                finally
                {
                    socketStream.Close();
                    connection.Close();
                }
            }
        }
    }
}
