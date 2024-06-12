// See https://aka.ms/new-console-template for more information
using StackExchange.Redis;
Console.WriteLine("Testing Garnet...!!!!");

var connString = "localhost:6379";
var  channelName = "messages";
var connection = ConnectionMultiplexer.Connect(connString);
ISubscriber sub = connection.GetSubscriber();

// sub.Publish("messages", "Hello, world!");

sub.Subscribe(channelName, (channel, message) => {
    Console.WriteLine((string)message);
});

while(1==1){
    Console.WriteLine("Waiting for messages...");
    System.Threading.Thread.Sleep(1000);
}

// Ctrl + C to stop the program