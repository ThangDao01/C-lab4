namespace Part4
{
    public abstract class Employee : Person
    {
        public string Department { get; set; }
        public int Salary { get; set; }
        public int DateHired { get; set; }

        public Employee()
        {
        }

        public Employee(string department, int salary, int dateHired)
        {
            Department = department;
            Salary = salary;
            DateHired = dateHired;
        }
        protected Employee(string name, int phoneNumber, string emailAddress, string department, int salary, int dateHired) : base(name, phoneNumber, emailAddress)
        {
            Department = department;
            Salary = salary;
            DateHired = dateHired;
        }

        public abstract void CalculateBonus();
        public abstract void CalculateVacation();
    }
}