///refactoring: nachdenken ob geschriebner code anders/besser dargestellt werden kann
//"base" keyword = "super" in java
using System;

namespace OOPExample.EmployeeClasses
{
    abstract class Employee : IPayable
    {
        //bei properties anfangsbuchstabe groß
        public string FirstName { get; /*private*/ set; } = string.Empty; //.Empty kann compiler im gegensatz zu leerstring prüfen
        public string LastName { get; set; } = string.Empty;

        public Employee() : this(Globals.UNKNOWN, Globals.UNKNOWN)
        {
        }

        public Employee(string firstName, string lastName) //bei parameter anfangsbuchstabe klein
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"First Name: {FirstName}, Last Name: {LastName}"; //string interpolation (mit $ keyword strings und variablen direkt vermischen) 
        }

        public abstract double calculateHourlyRate();
    }
}
