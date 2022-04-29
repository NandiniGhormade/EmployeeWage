using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Employee2
    {
        public const int Is_Full_time = 1;
        public const int Is_Part_time = 2;
        public static void EmployeeAttandance2()
        {
            int EMP_RATE_PER_HOUR = 20;
            int emphrs = 0;
            int empwage;
            Random obj = new Random();
            int num = obj.Next(0, 3);
            switch (num)
            {
                case Is_Full_time:
                    emphrs = 8;
                    break;
                case Is_Part_time:
                    emphrs = 4;
                    break;
                default:
                    emphrs = 0;
                    break;
            }
            empwage = emphrs + EMP_RATE_PER_HOUR;
            Console.WriteLine("The Employee wage of the day is:" + empwage);

        }
    }
}
    

