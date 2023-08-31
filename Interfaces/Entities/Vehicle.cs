
namespace Interfaces.Entities
{
    class Vehicle
    {
        public string Model { get; private set; }

        public Vehicle(string model)
        {
            Model = model;            
        }
    }
}
