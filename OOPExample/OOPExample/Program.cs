using System;
using System.Collections.Generic;
using OOPExample.EmployeeClasses;

namespace OOPExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] f = new Employee[3];
            f[0] = new PermanentEmployee("Franz", "Schuster", 15000.0);
            f[1] = new ContractEmployee("Hans", "Huber", 100.0);
            f[2] = new TempEmployee("Barbara", "Schmidt", 7.5);

            foreach(Employee emp in f)
            {
                Console.WriteLine(emp);
                Console.WriteLine($"Hourly rate: {emp.calculateHourlyRate().ToString("f2")}");
            }

        }
    }
}
