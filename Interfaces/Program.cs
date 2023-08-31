using System;
using System.Globalization;
using Interfaces.Entities;
using Interfaces.Service;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string carModel = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime Pickup = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime Return = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Vehicle vehicle = new Vehicle(carModel);
            CarRental carRental = new CarRental(Pickup, Return, vehicle);
            Console.Write("Enter price per hour: ");
            double perHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double perDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            RentalService rentalService = new RentalService(perHour, perDay, new BrazilTaxService());
            rentalService.ProcessingInvoice(carRental);
            Console.WriteLine(carRental.Invoice);
        }
    }
}
