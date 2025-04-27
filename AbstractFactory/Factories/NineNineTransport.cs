﻿using System;
using AbstractFactory.Aircrafts;
using AbstractFactory.Landvehicles;

namespace AbstractFactory.Factories
{
    public class NineNineTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Helicopter();
        }

        public ILandVehicle CreateTransportVehicle()
        {
            return new Motorcycle();
        }
    }
}
