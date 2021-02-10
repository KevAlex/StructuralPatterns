using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    //Concrete Decorator
    class Nitro : IComponente
    {
        // this variable points to the object, which can be decorated
        private IComponente decoratesTo;

        public Nitro(IComponente componen)
        {
            decoratesTo = componen;
        }

        public override string ToString()
        {
            return "Nitro Sistem \r\n" + decoratesTo.ToString();
        }
        public double Cost()
        {
            return decoratesTo.Cost() + 45;
        }

        public string Works()
        {
            return decoratesTo.Works() + ", Nitro ready";
        }

        public void NitroN()
        {
            Console.WriteLine("It uses Nitro");
        }
    }
}
