using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company 
{ 
    internal class Employee
    {
        public const int MinumimLoggedHours = 176;
        public const decimal OverTimeRate = 1.25m;
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal LoggedHours { get; set; }

        public decimal Wage { get; set; }
        public virtual decimal Calculate()
        {
            
            return CalculateBaseSalary() + CalculateOverTime();
        }
        private decimal CalculateBaseSalary()
        {
            return (Wage * MinumimLoggedHours);
        }
        private decimal CalculateOverTime ()
        {

            var AdditionalHours = ((LoggedHours - MinumimLoggedHours) > 0) ? LoggedHours - MinumimLoggedHours : 0;

            return (AdditionalHours * Wage * OverTimeRate);


                }
        public override string ToString()
        {
            var Type = GetType().ToString().Replace("Company", "");
            return $"\n {Type}"+
                $"\n Id : {Id}" +
                    $"\n Name : {Name}" +
                    $"\n Logged Hours : {LoggedHours} hrs " +
                    $"\n Waged : {Wage} $/hr " +
                    $"\n Base Salary : ${CalculateBaseSalary()}" +
                    $"\n Over Time : {CalculateOverTime()}";
        }

    }
}
