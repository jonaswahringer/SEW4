﻿using System;
namespace OOPExample.EmployeeClasses
{
    class TempEmployee : Employee //extends equivalent
    {
        private double HourlyRate { get; set; } = 0.0;

        public TempEmployee() : base(UNKNOWN, UNKNOWN)
        {
        }

        public TempEmployee(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public TempEmployee(string firstName, string lastName, double hourlyRate) : base()
        {
            this.HourlyRate = hourlyRate;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Hourly Rate: {HourlyRate}";
        }

        public override double calculateHourlyRate()
        {
            return HourlyRate*8;
        }
    }
}