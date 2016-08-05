using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;
using AkkaDistributedSystemsExample.Actors;
using AkkaDistributedSystemsExample.MessageType;

namespace AkkaDistributedSystemsExample
{
    public class Program
    {
        static void Main(string[] args)
        {
    //        //// Create a new actor system (a container for your actors)
    //        //var system = ActorSystem.Create("MySystem");

    //        //// Create your actor and get a reference to it.
    //        //// This will be an "ActorRef", which is not a
    //        //// reference to the actual actor instance
    //        //// but rather a client or proxy to it.
    //        //var greeter = system.ActorOf<GreetingActor>("greeter");

    //        //// Send a message to the actor
    //        //greeter.Tell(new GreetMessage("World"));

    //        //// This prevents the app from exiting
    //        //// before the async work is done
    //        //Console.ReadLine();

    //        var fluentConfig = FluentConfig.Begin()
    //        .StartRemotingOn("localhost", 8081)
    //        .Build();

    //        using (var system = ActorSystem.Create("my-actor-server", fluentConfig))
    //        {
    //            //start two services
    //            var service1 = system.ActorOf<Service1>("service1");
    //            var service2 = system.ActorOf<Service2>("service2");
    //            Console.ReadKey();
            }
    }
}
