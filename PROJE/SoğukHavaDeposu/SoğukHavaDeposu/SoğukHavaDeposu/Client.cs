using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoğukHavaDeposu
{
    public abstract class Client
    {
        public abstract void Connect();
    }
    internal class RequestClient : Client
    {
        public override void Connect()
        {
            Console.WriteLine("Connecting to something with RequestClient...");
        }
    }
}
