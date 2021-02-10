using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CompositeElement root = new CompositeElement("Pict");
            root.Add(new PrimitiveElement("Red"));
            root.Add(new PrimitiveElement("Blue"));
            root.Add(new PrimitiveElement("Green"));

            CompositeElement comp =
        new CompositeElement("Two Circles");
            comp.Add(new PrimitiveElement("Black Circle"));
            comp.Add(new PrimitiveElement("White Circle"));
            root.Add(comp);

            PrimitiveElement alo = new PrimitiveElement("ACA");
            root.Add(alo);
            root.Display(4);

        }
    }

    // Component class
    abstract class DrawingElement
    {

        protected string _name;

        public DrawingElement(string name)
        {
            _name = name;
        }
       /*  public virtual void Operation()
        {
            Console.WriteLine("gg");
        }
       */

        public abstract void Add(DrawingElement compo);

        public abstract void Remove(DrawingElement compo);
        public abstract void Display(int iden);

        

    }


    //Leaf class
    class PrimitiveElement : DrawingElement
    {
        public PrimitiveElement(string name) : base(name)
        {

        }

        public override void Add(DrawingElement compo)
        {
            Console.WriteLine(
        "Cannot add to a PrimitiveElement");
        }

        public override void Display(int iden)
        {
            Console.WriteLine(
        new String('-', iden) + " " + _name);
        }

        

        public override void Remove(DrawingElement compo)
        {
            Console.WriteLine(
        "Cannot Remove from a PrimitiveElement");
        }
    }

    //Composite class
    class CompositeElement : DrawingElement
    {
        private List<DrawingElement> kk = new List<DrawingElement>();

        public CompositeElement(string name) : base(name)
        {

        }

        public override void Add(DrawingElement compo)
        {
            kk.Add(compo);
        }

        public override void Remove(DrawingElement compo)
        {
            kk.Remove(compo);

        }

        public override void Display(int iden)
        {
            Console.WriteLine(new String('-', iden) + "+" + _name);

            foreach (DrawingElement item in kk)
            {
                item.Display(iden + 2);
            }
        }
    }

}
