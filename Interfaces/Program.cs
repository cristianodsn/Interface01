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
            DateTime d1 = new DateTime(2023, 08, 27, 12, 0, 0);
            Console.WriteLine(d1.Day);
            DateTime d2 = DateTime.Now;
            Console.WriteLine(d2.Day);
            TimeSpan t1 = d2.Subtract(d1);
            Console.WriteLine(t1.TotalDays);
            int aux =(int) Math.Ceiling(t1.TotalDays);
            Console.WriteLine(aux);
        }
    }
}
