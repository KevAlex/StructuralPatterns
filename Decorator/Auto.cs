using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Auto : IComponente
    {
        private string model;
        private string caract;
        public double cost;

        public string Model { get => model; set => model = value; }
        public string Caract { get => caract; set => caract = value; }

        public Auto(string modelo, string caract, double cost)
        {
            model = modelo;
                this.caract = caract;
            this.cost = cost;
        }

        //Own method of the car

        public void Doors(bool states)
        {
            if (states)
                Console.WriteLine("closed doors");
            else
                Console.WriteLine("opened doors");

        }

        public override string ToString()
        {
            return string.Format("Model {0}, {1} \r\n", Model, Caract );
        }
        public double Cost()
        {
            return cost;
        }

        public string Works()
        {
            return "turned on engine";
        }
    }
}
