using System;
using System.Collections.Generic;
using OOPExample.EmployeeClasses;

namespace OOPExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];
            employees[0] = new PermanentEmployee("Franz", "Schuster", 15000.0);
            employees[1] = new ContractEmployee("Hans", "Huber", 100.0);
            employees[2] = new TemporaryEmployee("Barbara", "Schmidt", 7.5);

            foreach(Employee emp in employees)
            {
                Console.Write(emp);
                Console.WriteLine($", Hourly rate: {emp.calculateHourlyRate().ToString("f2")}");
            }

        }
    }
}
