
using Company;
using System;
using System.Numerics;

namespace Company
{
    class Program
    {

        public static void Main(String[] args)

        {
            Manager m = new Manager
            {
                Id = 1000,
                Name = "Ali ",
                LoggedHours = 180,
                Wage = 10 

               
            };
            

           Maintanance n = new Maintanance
            {
                Id = 1001,
                Name = "SAlim ",
                LoggedHours = 182,
                Wage = 8


            };
           Sales s = new Sales
           {
                Id = 1002,
                Name = "SAlly ",
                LoggedHours = 176,
                Wage = 9 ,
                Commission=0.05m,
                SalesVolume = 10000m
                

            };
            Employee[] employees = { m, n, s };
            foreach (var employee in employees)
            {
                Console.WriteLine("\n ------------------------");
                Console.WriteLine(employee);
            }


        }
    }
        
      

}

