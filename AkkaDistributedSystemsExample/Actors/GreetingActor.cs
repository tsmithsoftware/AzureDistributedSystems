using System;
using Akka.Actor;
using AkkaDistributedSystemsExample.MessageType;

namespace AkkaDistributedSystemsExample.Actors
{
    public class GreetingActor:ReceiveActor
    {
        public GreetingActor()
        {
            // Tell the actor to respond
            // to the Greet message
            Receive<GreetMessage>(greet =>
               Console.WriteLine("Hello {0}", greet.Who));
        }
    }
}
