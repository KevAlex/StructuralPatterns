using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Aleron : IComponente
    {
        private IComponente decoratesTo;

        public Aleron(IComponente decoratesTo)
        {
            this.decoratesTo = decoratesTo;
        }

        public override string ToString()
        {
            return "Aleron \r\n" + decoratesTo.ToString();
        }
        public double Cost()
        {
            return decoratesTo.Cost() + 60;
        }

        public string Works()
        {
            return decoratesTo.Works() + ", Aleron ready";

        }
    }
}
