using System;

namespace TCPsim_server
{
    class Program
    {
        static public void Main()
        {
            var socket = new TCPSim_server();

            socket.Start();
        }
    }
}