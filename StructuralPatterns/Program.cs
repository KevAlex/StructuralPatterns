using System;

namespace StructuralPatterns
{//this is the client
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int res = 0;
            ITarget ne = new Calculate();

            res = ne.Sumar(7, 8);
            Console.WriteLine(res);

            ne = new Adapter();

            // the client uses the other class based on the previous behaviour 
            res = ne.Sumar(1, 2);

            Console.WriteLine(res);

        }
    }
}
