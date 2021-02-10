using System;
using System.Collections.Generic;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Dictionary<string, double> products = new Dictionary<string, double>();

            products.Add("M101", 33);
            products.Add("C654", 622);
            products.Add("D54", 122);
            products.Add("C555", 2);

            // creation of Bridge 
            Abstraction bridge = new Abstraction(new Impl32(), products);

            bridge.ShowTotal();
            bridge.List();

        }

    }
}
