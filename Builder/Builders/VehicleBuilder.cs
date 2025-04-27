using Builder.Components;
using Builder.Products;

namespace Builder.Builders
{
    public class VehicleBuilder : IBuilder
    {
        protected Vehicle vehicle = new Vehicle();
        public Vehicle GetVehicle()
        {
            Vehicle result = vehicle;
            Reset();
            return result;
        }

        public void Reset()
        {
            vehicle = new Vehicle();
        }

        
        public void SetAirbag(AirBag airBag)
        {
            vehicle.AirBag = airBag;
        }

        public void SetEngine(Engine engine)
        {
            vehicle.Engine = engine;
        }

        public void SetSeats(int seats)
        {
            vehicle.Seats = seats;
        }

        public void SetTransmission(Transmission transmission)
        {
            vehicle.Transmission = transmission;
        }

        public void SetVehicleType(VehicleType vehicleType)
        {
            vehicle.VehicleType = vehicleType;
        }
    }
}
