using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class Imple1 : IBridge
    {
        public void ProductsList(Dictionary<string, double> pProduct)
        {
            foreach (KeyValuePair<string, double> item in pProduct)
            {
                Console.WriteLine(item.Key);
            }
        }

        public void ShowTotal(Dictionary<string, double> pProduct)
        {
            double total = 0;
            int quantity = 0;

            foreach (KeyValuePair<string,double> item in pProduct)
            {
                total += item.Value;
                quantity++;
            }

            Console.WriteLine("Total {0} productos is ${1}", quantity, total);
        }
    }
}
