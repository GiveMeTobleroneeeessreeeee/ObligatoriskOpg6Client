using System;
using System.IO;
using System.Net.Sockets;

namespace ObligatoriskOpg6Client
{
    class Program
    {
        static void Main()
        {
            try
            {
                TcpClient client = new TcpClient("127.0.0.1", 4646);
                StreamReader reader = new StreamReader(client.GetStream());
                StreamWriter writer = new StreamWriter(client.GetStream());

                string s = string.Empty;
                while (!s.Equals("Exit"))
                {
                    Console.Write("Enter a string to send to the server: ");
                    s = Console.ReadLine();
                    Console.WriteLine(s);
                    writer.Flush();
                    string server_string = reader.ReadLine();
                    Console.WriteLine(server_string);

                }
                reader.Close();
                writer.Close();
                client.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }
        }
    }
}
