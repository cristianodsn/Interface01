using System;
using System.Globalization;
using Interfaces.Entities;

namespace Interfaces.Service
{
    class RentalService
    {
        public double  PricePerHour { get; set; }
        public double PricePerDay { get; set; }
        private BrazilTaxService _brazilTaxService;

        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessingInvoice(CarRental carRental)
        {
            Invoice invoice;
            TimeSpan t = carRental.Finish - carRental.Start;
            if(t.TotalHours > 12)
            {

              
            }
        }
    }
}
