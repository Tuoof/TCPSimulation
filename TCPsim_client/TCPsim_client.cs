using System;
using System.IO;
using System.Net.Sockets;

namespace TCPsimulation_client
{
    class TCPSim_client
    {
        public void Start()
        {
            try
            {
                //this computer  
                Console.WriteLine(" Client Started ");
                TcpClient clientSocket = new TcpClient();
                clientSocket.Connect ("127.0.0.1", 5000);
                Console.WriteLine(" Server Connected ");

                StreamWriter writer = new StreamWriter(clientSocket.GetStream());

                while (true)
                {
                    if (clientSocket.Connected)
                    {
                        //send message  
                        string input = Console.ReadLine();
                        writer.WriteLine(input);
                        writer.Flush();
                    }
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            Console.WriteLine("Press any key to exit from client program");
            
            Console.ReadKey();
        }
    }
}