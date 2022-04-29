using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Employee1
    {
        public static void  EmployeeAttendance()
        {
            Random obj = new Random();
            int num =obj.Next(0,2);
            if (num == 1)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }

    }
}
