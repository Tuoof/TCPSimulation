using System;

namespace TCPsimulation_client
{
    class Program
    {
        static void Main()
        {
            var client = new TCPSim_client();

            client.Start();
        }
    }
}