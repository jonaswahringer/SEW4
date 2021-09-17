using System;
using System.Collections.Generic;
using OOPExample.EmployeeClasses;

namespace OOPExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee mike = new PermanentEmployee();
            Employee karl = new PermanentEmployee("Karl", "Landsteiner", 100);
            Employee karl2 = new PermanentEmployee("Karl", "Zwei");
            Employee sue = new ContractEmployee
            {
                FirstName = "Sue",
                LastName = "Permarkt",
            };
            Console.WriteLine(sue.ToString()); //toString wird automatisch aufgerufen
            Console.WriteLine(sue.FirstName);
            sue.FirstName = "Neuer Name";
            sue.Test();
            Console.WriteLine(Globals.DEFAULT_WORK_DAYS_PER_YEAR);
            Console.WriteLine(karl);
            Console.WriteLine(karl2);


            Employee[] f = new Employee[3];
            f[0] = new PermanentEmployee("Franz", "Schuster", 15000.0);
            f[1] = new ContractEmployee("Hans", "Huber", 100.0);
            f[2] = new TempEmployee("Barbara", "Schmidt", 7.5);

            Console.WriteLine(f[0].calculateHourlyRate());

            foreach(Employee emp in f)
            {
                Console.WriteLine(emp);
                Console.WriteLine(emp.calculateHourlyRate().ToString("f2"));
            }

        }
    }
}
