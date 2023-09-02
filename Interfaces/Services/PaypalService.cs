namespace Interfaces.Services
{
    class PaypalService : IPaymentService
    {
        public double PaymentFee(double amount)
        {
            return amount + (amount* 0.02);
        }
        
        public double Interest(double amount, int date)
        {
            return amount + (amount / 100 * date); 
        }
    }
}
