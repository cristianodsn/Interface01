using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Entities
{
    class Contract
    {
        public int Number { get; private set; }
        public DateTime Date { get; private set; }
        public double TotalValue { get; private set; }
        public List<Installment> Installments { get; private set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue; 
            Installments = new List<Installment>();
        }            
               
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Installments:");
            foreach(Installment obj in Installments)
            {
                sb.Append(obj.DueDate.ToShortDateString().ToString());
                sb.Append(" - ");
                sb.Append("$");
                sb.AppendLine(obj.Amount.ToString("F2", CultureInfo.InvariantCulture));
            }
            return sb.ToString();
        }
    }
}
