using System;
using EasyNetQ;
using Messages;

namespace Publisher
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var bus = RabbitHutch.CreateBus("host=localhost"))
            {
                var input = String.Empty;
                Console.WriteLine("Enter a message. 'Quit' to quit.");
                int i = 1;
                while (true)
                {
                    bus.PubSub.Publish(new TextMessage { Text = $"Message Number {i}" });
                    Console.WriteLine($"Message {i} published!");
                    i++;
                }
            }
        }
    }
}
