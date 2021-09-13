using System;

namespace TCPsimulation_server
{
    class Program
    {
        static public void Main()
        {
            var server = new TCPSim_server();

            server.Start();
        }
    }
}