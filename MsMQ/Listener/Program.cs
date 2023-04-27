using Common;
using Experimental.System.Messaging;
using Listener;

// TestMsMQ adında queue'yu getir yoksa da oluştur ve bu queue'yu getir
var testQueue = new MessageQueue().CheckQueue("TestMsMQ");

testQueue.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });

//ReceiveCompleted Event'ini gelen mesajları okuyabilmek için takip diyoruz
testQueue.ReceiveCompleted += Queue_ReceiveCompleted.Receive;

//Gelen mesajları almaya başlıyoruz
testQueue.BeginReceive();

Console.ReadLine();