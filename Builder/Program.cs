using System;
using Builder.Builders;
using Builder.Directors;
using Builder.Products;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilder builder = new VehicleBuilder();
            Director director = new Director(builder);

            director.ConstructSedanCar();

            Vehicle vehicle = builder.GetVehicle();

            Console.WriteLine($"Criado um veiculo do tipo {vehicle.VehicleType}");

            director.ConstructTruck();

            Vehicle truck = builder.GetVehicle();

            Console.WriteLine($"Criado um veiculo do tipo {truck.VehicleType}");

            director.ConstructSuv();
            Vehicle suv  = builder.GetVehicle();

            Console.WriteLine($"Criado um veiculo do tipo {suv.VehicleType}");

            Console.ReadLine();
        }
    }
}
