using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    internal class Sales : Employee
    {
        public decimal SalesVolume { get; set; }
        public decimal Commission { get; set; }
        

        public override decimal Calculate()
        {
            return base.Calculate() + CalculateBonus();
        }
        private decimal CalculateBonus()
        {
            return Commission* SalesVolume;
        }
        public override string ToString()
        {
            return base.ToString() +
                $"\n Bonus  : {Math.Round ( CalculateBonus() , 2) }" +
                 $"\n Commission  : {Math.Round(Commission ,2)}" +
                $"\n Net Salary : {this.Calculate()}";
        }
    }
}
