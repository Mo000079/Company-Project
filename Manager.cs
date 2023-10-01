using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    internal class Manager : Employee
    {
        public const decimal AllowanceRate = 0.05m;
        
        public override decimal Calculate()
        {
            return base.Calculate() + CalculateAllowance();
        }
        private decimal CalculateAllowance()
        {
            return AllowanceRate * base.Calculate();
        }
        public override string ToString()
        {
            return base.ToString() +
                $"\n Allowance : {CalculateAllowance()}" +
                $"\n Net Salary : {this.Calculate()}";
        }
    }

   
}
