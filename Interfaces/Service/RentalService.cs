using System;
using Interfaces.Entities;

namespace Interfaces.Service
{
    class RentalService
    {
        public double  PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }
        private ITaxService _TaxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _TaxService = taxService;
        }

        public void ProcessingInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish - carRental.Start;
            double basicPayment = 0.0;

            if(duration.TotalHours > 12)
            {
                basicPayment = Math.Ceiling(duration.TotalDays) * PricePerDay;
            }
            else
            {
                basicPayment = Math.Ceiling(duration.TotalHours) * PricePerHour;
            }

            double tax = _TaxService.Tax(basicPayment);
            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
