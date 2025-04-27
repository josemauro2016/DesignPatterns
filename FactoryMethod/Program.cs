﻿using System;
using FactoryMethod.Factories;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transport transport = null;
            if (args.Length > 0 && args[0] == "--uber")
            {
                transport = new CarTransport();
            }else if(args.Length > 0 && args[0] == "--log")
            {
                transport = new MotorcycleTransport();
            }else if(args.Length > 0 && args[0] == "--bike")
            {
                transport = new BikeTransport();
            }
            else
            {
                Console.WriteLine("Selecione o tipo do serviço");
            }

            if (transport != null)
            {
                transport.StartTransport();
            }

            Console.ReadLine();
        }
    }
}
