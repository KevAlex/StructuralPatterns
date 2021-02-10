using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            // trying changes with c#
            Proxy.ISubject myPro = new Proxy.Proxys();

            myPro.Reuquest(1);
            myPro.Reuquest(2);

            Console.WriteLine("Hello World!");

            Proxy.ISubject myProS = new Proxy.SecureProxy();
            myProS.Reuquest(1);
        }
    }
}
