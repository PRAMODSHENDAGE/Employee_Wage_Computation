using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public int ComputeEmpWages(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0; //initializing Variable
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays <= numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3); //Random Value passes 0 to 2
                switch (empCheck) 
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day :" + totalWorkingDays + " Emp Hrs :" + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage for company : " + company + " is : " + totalEmpWage);
            return totalEmpWage;
        }
    }
}
