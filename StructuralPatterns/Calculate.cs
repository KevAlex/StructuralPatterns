using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralPatterns
{
    // original class
    class Calculate : ITarget
    {
        public int Sumar(int a, int b)
        {
            return a + b;
        }
    }
}
