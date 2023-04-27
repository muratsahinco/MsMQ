using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Experimental.System.Messaging;

namespace Common
{
    public static class MessageQueueHelper
    {
        public static MessageQueue CheckQueue(this MessageQueue mq, string queueName)
        {
            //Private dediğimiz queue'nin private olduğunu belirtiyor. Diğer kullanımlar için bu alan değişebilir ya da dinamik hale getirilebilir. 

            if (MessageQueue.Exists($@".\Private$\{queueName}"))
            { //Queue mevcut
                return new MessageQueue($@".\Private$\{queueName}");
            }
            else
            { //Queue mevcut değil
                return MessageQueue.Create($@".\Private$\{queueName}");
            }
        }
    }
}
