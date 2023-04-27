using Experimental.System.Messaging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listener
{
    public static class Queue_ReceiveCompleted
    {
        public static void Receive(object sender, ReceiveCompletedEventArgs e)
        {
            var mailQueue = (MessageQueue)sender;

            //Mesajı okuyoruz
            var msg = (string)e.Message.Body;

            Console.WriteLine($"msg : " + msg);

            //Mesaj almaya devam ediyoruz
            mailQueue.BeginReceive();
        }
    }
}
