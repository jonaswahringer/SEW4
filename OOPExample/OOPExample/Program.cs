using System;
using System.Collections.Generic;
using System.Linq; //eingebettete SQL language -> mit der syntax kann auch auf datenbanken zugegriffen werden
using OOPExample.EmployeeClasses;

namespace OOPExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee[] employees = new Employee[3];
            //employees[0] = new PermanentEmployee("Franz", "Schuster", 15000.0);
            //employees[1] = new ContractEmployee("Hans", "Huber", 100.0);
            //employees[2] = new TemporaryEmployee("Barbara", "Schmidt", 7.5);

            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new PermanentEmployee
            {
                FirstName = "Mike",
                LastName = "Rohsoft"
            });
            employeeList.Add(new PermanentEmployee("Franz", "Schuster", 15000.0));
            employeeList.Add(new ContractEmployee("Hans", "Huber", 100.0));
            employeeList.Add(new TemporaryEmployee("Barbara", "Schmidt", 7.5));

            //ausgabe
            //foreach (Employee emp in employeeList)
            //{
            //    Console.Write(emp);  //ToString wird ausgegeben
            //    Console.WriteLine($", Hourly rate: {emp.calculateHourlyRate().ToString("f2")}");
            //}

            //sortiert nach nachnahme
            //orderby with linq -> SQL ähnlich
            var sortedEmployeeList = from e in employeeList
                                     orderby e.LastName ascending
                                     select e;

            //sort with linq
            //employeeList.Sort((x, y) => x.LastName.CompareTo(y.LastName));

            //sortierte ausgabe
            sortedEmployeeList.ToList().ForEach(Console.WriteLine);

            //GUID - Global Unified Identifier: 64Bit Zeichenketten die eindeutig idenftifizieren
            Dictionary<Guid, Employee> employeeDict = new Dictionary<Guid, Employee>();
            employeeDict.Add(Guid.NewGuid(), new PermanentEmployee { FirstName = "Luci", LastName = "Fer"});
            Console.WriteLine();

        }
    }
}
