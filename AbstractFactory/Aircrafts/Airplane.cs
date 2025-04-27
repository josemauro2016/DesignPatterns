using System;

namespace AbstractFactory.Aircrafts
{
    internal class Airplane : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos, ventos OK!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros à bordo, vôo autorizado.");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando decolagem...");
        }
    }
}
