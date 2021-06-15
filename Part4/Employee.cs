namespace Part4
{
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

            protected Employee(string department, int salary, int dateHired)
            {
                Department = department;
                Salary = salary;
                DateHired = dateHired;
            }

            protected Employee(string name, string phone, string email, string department, int salary, int dateHired) :
                base(name, phone, email)
            {
                Department = department;
                Salary = salary;
                DateHired = dateHired;
            }

            public abstract void CalculateBonus();
            public abstract void CalculateVacation();
        }
    }
}