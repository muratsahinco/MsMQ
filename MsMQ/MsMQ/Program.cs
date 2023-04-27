using Common;
using Experimental.System.Messaging;

// TestMsMQ adında queue'yu getir yoksa da oluştur ve bu queue'yu getir
var testQueue = new MessageQueue().CheckQueue("TestMsMQ");
testQueue.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });

var msg = $"test - {Guid.NewGuid().ToString()}";
Console.WriteLine(msg);

//Mesajın queue'ya eklenmesi
testQueue.Send(msg);

Console.ReadLine();