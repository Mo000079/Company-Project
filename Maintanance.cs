using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company;

internal class Maintanance : Employee
{
    public const decimal Hardship = 100m;

    public override decimal Calculate()
    {
        return base.Calculate() + Hardship;
    }

    public override string ToString()
    {
        return base.ToString() +
            $"\n HardShip : {Math.Round(Hardship, 2)}" +
            $"\n Net Salary : {this.Calculate()}";
    }
}
