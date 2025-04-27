using System;

namespace AbstractFactory.Aircrafts
{
    internal class Drone : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Ventos OK!, Céu aberto.");
        }

        public void GetCargo()
        {
            Console.WriteLine("Encomenda acoplada");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando a entrega.");
        }
    }
}
