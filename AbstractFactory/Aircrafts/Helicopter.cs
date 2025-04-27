using System;

namespace AbstractFactory.Aircrafts
{
    internal class Helicopter : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando ventos, vento sudeste, ventos OK!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros OK! Ligando as helices.");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando a decolagem!!!");
        }
    }
}
