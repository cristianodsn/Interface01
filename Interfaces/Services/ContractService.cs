using System;
using Interfaces.Entities;

namespace Interfaces.Services
{
    class ContractService
    {
        public void ProcessContract(Contract contract, int months, IPaymentService paymentService)
        {
            double valueInstallment = contract.TotalValue / months;          
            
            for(int i = 1; i <= months; i++)
            {
                DateTime dueDate = contract.Date.AddMonths(i);
                double interest = paymentService.Interest(valueInstallment, i);
                double paymentFee = paymentService.PaymentFee(interest);
                Installment installment = new Installment(dueDate, paymentFee);
                contract.Installments.Add(installment);                  
            }
        }
    }
}
