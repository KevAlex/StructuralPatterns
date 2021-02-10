using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class Impl32 : IBridge
    {
        
        public void ProductsList(Dictionary<string, double> pProduct)
        {
            foreach (KeyValuePair<string, double> item in  pProduct)
            {
                if (item.Key[0] == 'C')
                    Console.ForegroundColor = ConsoleColor.Green;
                if (item.Key[0] == 'M')
                    Console.ForegroundColor = ConsoleColor.Yellow;

                if (item.Key[0] == 'D')
                    Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("{0} - {1}", item.Key, item.Value);
            }

        }

        public void ShowTotal(Dictionary<string, double> pProduct)
        {
            double total = 0;
            double totalm = 0;
            double totalc = 0;
            double totald = 0;
            int quantity = 0;

            foreach (KeyValuePair<string, double> item in pProduct)
            {
                total += item.Value;
                if (item.Key[0] == 'C')
                    totalc += item.Value;
                if(item.Key[0] == 'M')
                    totalm += item.Value;
                if (item.Key[0] == 'D')
                    totald += item.Value;
                quantity++;
            }

            Console.WriteLine("Total of sports is ${0}", totald);
            Console.WriteLine("Total of m is ${0}", totalm);
            Console.WriteLine("Total of C is ${0}", totalc);
            Console.WriteLine("Total {0}", total);



        }
    }
}
