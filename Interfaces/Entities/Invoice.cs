
namespace Interfaces.Entities
{
    class Invoice
    {
        public double BasicPayment { get; private set; }
        public double Tax { get; private set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get
            {
                return BasicPayment * Tax;
            }
        } 
    }
}
