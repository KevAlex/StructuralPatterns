using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class Proxy
    {
        public interface ISubject
        {
            void Reuquest(int opcion);
        }

        // The real Proxy class, which gives access
        public class Proxys : ISubject
        {
            private Kitchen kitchen;
            public void Reuquest(int opcion)
            {
                if (kitchen == null)
                {
                    Console.WriteLine("Activating subject");
                    kitchen = new Kitchen();
                }
                if (opcion == 1)
                    kitchen.SecretReecipe();
                if (opcion == 2)
                    kitchen.Kitc(5);
                

            }
        }

        public class SecureProxy:ISubject
        {
            private Kitchen kitchen;
            private string pass;

            public void Random()
            {

                Console.WriteLine("give me pass");
            }

            public void Reuquest(int opcion)
            {
                Console.WriteLine("Give me pass");
                pass = Console.ReadLine();

                if (pass == "234") { 

                    if(kitchen == null)
                        Console.WriteLine("Activating subject");
                        kitchen = new Kitchen();
                    if (opcion == 1)
                        kitchen.SecretReecipe();
                    if (opcion == 2)
                        kitchen.Kitc(5);

                }
                else
                {
                    Console.WriteLine("Access denied");
                }
            }
        }

    
    private class Kitchen
        {
            public void SecretReecipe()
            {
                Console.WriteLine("Bread");
                Console.WriteLine("Oil");
                Console.WriteLine("Especias");
                Console.WriteLine("Cheese");

            }
       
        public void Kitc(int n)
            {
                Console.WriteLine("Cooking {0} recipes, ", n);
            }
        }
    
    }
}
