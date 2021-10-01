using System;
namespace OOPExample.EmployeeClasses

{
    class PermanentEmployee : Employee
    {
        private double Salary { get; set; } = 0.0;

        public PermanentEmployee() : base(UNKNOWN, UNKNOWN)
        {
        }

        public PermanentEmployee(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public PermanentEmployee(string firstName, string lastName, double salary) : base(firstName, lastName)
        {
            this.Salary = salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Salary: {Salary}";
        }

        override public double calculateHourlyRate()
        {
            return ((this.Salary / Globals.DEFAULT_WORK_DAYS_PER_YEAR) / Globals.DEFAULT_WORK_HOURS_PER_DAY);
        }
    }
}
