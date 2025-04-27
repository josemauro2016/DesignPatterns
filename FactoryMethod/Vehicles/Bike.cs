using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Vehicles
{
    public class Bike : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegue as encomendas");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Pedale até o trageto.");
        }
    }
}
