using System;
using Interfaces.Entities;

namespace Interfaces.Services
{
    class ContractService
    {
        private IPaymentService _paymentService;

        public ContractService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double valueInstallment = contract.TotalValue / months;          
            
            for(int i = 1; i <= months; i++)
            {
                DateTime dueDate = contract.Date.AddMonths(i);
                double upDatevalue = _paymentService.Interest(valueInstallment, i) + valueInstallment;
                double totalValue = _paymentService.PaymentFee(upDatevalue) + upDatevalue;  
                Installment installment = new Installment(dueDate, totalValue);
                contract.Installments.Add(installment);                  
            }
        }
    }
}
