using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IComponente myCar = new Auto("Ferrari", "2 doors", 500);

            //Here I call the function ToString()
                Console.WriteLine(myCar);

            //Cast because myCar is type IComponent and not type Auto directly
            ((Auto)myCar).Doors(true);

            // Here, the car is decorated with the concrete decorator 
            myCar = new Sound(myCar);
            Console.WriteLine(myCar.Cost());
            Console.WriteLine(myCar.Works());

            Console.WriteLine(myCar);

            myCar = new Nitro(myCar);
            Console.WriteLine(myCar.Cost());
            Console.WriteLine(myCar.Works());
            //Cast, same reason line 16
            ((Nitro)myCar).NitroN();

            Console.WriteLine(myCar);



            // If I want to use specific methods of a previous dcorator class 
            // It is not possible
            //((Auto)myCar).Doors(true);
        }
    }
}
