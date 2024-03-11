using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;

namespace client
{
    public class Whois
    {
        static void Main(string[] args)
        {
            try
            {
                TcpClient client = new TcpClient();
                client.Connect("whois.networksolutions.com", 43);
                StreamWriter sw = new StreamWriter(client.GetStream());
                StreamReader sr = new StreamReader(client.GetStream());
                if (args.Length >= 1)
                {
                    sw.WriteLine(args[0]);
                    sw.Flush();
                    Console.WriteLine(sr.ReadToEnd());

                }
                else
                {
                    Console.WriteLine("No arguments.");
                }
            }
            catch
            {
                Console.WriteLine("Something went wrong.");
            }
        }
    }
}
