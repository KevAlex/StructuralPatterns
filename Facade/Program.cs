using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Facade dc = new Facade();

            dc.Buy();
            dc.Buy();
            dc.Buy();
            dc.Buy();
            dc.Buy();
        }
    }
}
