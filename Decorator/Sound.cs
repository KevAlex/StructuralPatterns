using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Sound : IComponente
    {
        private IComponente decoratesTo;

        public Sound(IComponente comp)
        {
            decoratesTo = comp;
        }
        public double Cost()
        {
            return decoratesTo.Cost() + 15;

        }

        public string Works()
        {
            return decoratesTo.Works() + ", Sound system ready";

        }
        public override string ToString()
        {
            return "Sound System \r\n" + decoratesTo.ToString();
        }
    }
}
