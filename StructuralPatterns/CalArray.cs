using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralPatterns
{
    //Class to be adapted
    class CalArray
    {
        public double suma(int[] oper)
        {
            int n = 0;
            double r = 0;

            for (int i = 0; i < oper.Length; i++)
            {
                r = r+ oper[i];
            }
            return r;
        }
    }
}
