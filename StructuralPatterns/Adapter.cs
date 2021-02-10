using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralPatterns
{
    class Adapter : ITarget
    {
        CalArray adapt = new CalArray();
        // Here is done the the adapter
        public int Sumar(int a, int b)
        {
            double r = 0;

            //It is created the array from the adapter
            int[] opera =  { a, b };

            // the operation of the adapter is executed
            r = adapt.suma(opera);

            return (int)r;
        }
    }
}
