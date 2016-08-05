using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkkaDistributedSystemsExample.MessageType
{
    public class GreetMessage
    {
        public GreetMessage(string who)
        {
            Who = who;
        }
        public string Who { get; private set; }
    }
}
