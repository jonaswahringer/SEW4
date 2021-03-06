namespace OOPExample.EmployeeClasses
{
    class ContractEmployee : Employee
    {
        private double DailyRate { get; set; } = 0.0;

        public ContractEmployee() : base(Globals.UNKNOWN, Globals.UNKNOWN)
        {
        }

        public ContractEmployee(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public ContractEmployee(string firstName, string lastName, double dailyRate) : base(firstName, lastName)
        {
            this.DailyRate = dailyRate;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Daily Rate: {DailyRate}";
        }

        public override double calculateHourlyRate()
        {
            return DailyRate/Globals.DEFAULT_WORK_HOURS_PER_DAY;
        }
    }
}
