using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Subscriber
    {
        private string name;

        public Subscriber(string name)
        {
            this.name = name;
        }

        public void OnMessageReceived(object sender, MessageEvents message)
        {
            Console.WriteLine($"{name} got a message: {message.Message}");
        }
        public void OnComplaintMessageReceived(object sender, MessageEvents message)
        {
            Console.WriteLine($"{name} got a message: {message.Message}");
        }

    }
}
