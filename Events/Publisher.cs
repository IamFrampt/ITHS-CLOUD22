using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{

    class MessageEvents : EventArgs
    {
        public string Message { get; set; }
        public MessageEvents(string message)
        {
            Message = message;
        }
    }

    internal class Publisher
    {
        public delegate void SendingMessage(object sender, MessageEvents args);

        //public event SendingMessage OnMessage;
        public event SendingMessage OnMessageComplaint;


        public event EventHandler<MessageEvents> OnMessage;

        public void SendMessage(string text)
        {
            OnMessage?.Invoke(this,new MessageEvents(text));
        }
        public void ComplaintMessage(string text)
        {
            OnMessageComplaint?.Invoke(this, new MessageEvents(text));
        }

    }
}
