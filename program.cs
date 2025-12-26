using System;
using System.Net.NetworkInformation;

namespace SignalX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- SIGNAL-X NETWORK TRACER ---");
            string host = "8.8.8.8"; // Google DNS
            
            try 
            {
                Ping pinger = new Ping();
                PingReply reply = pinger.Send(host);

                if (reply.Status == IPStatus.Success)
                {
                    Console.WriteLine($"[SUCCESS] Connection to {host} active.");
                    Console.WriteLine($"[LATENCY] {reply.RoundtripTime}ms");
                }
                else
                {
                    Console.WriteLine("[FAILED] Host unreachable.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] {ex.Message}");
            }
            
            Console.WriteLine("-------------------------------");
        }
    }
}
