using System;
using Part4.Part4;

namespace Part4
{
    public class Staff : Employee
    {
        public string Title { get; set; }
        public override void CalculateBonus()
        {
            double bonus = 1000 + 0.05 * Salary;
            Console.WriteLine($"Bonus: {bonus}");
        }

        public override void CalculateVacation()
        {
            int vacationWeek = 3;
            if (DateHired > 1825)
            {
                vacationWeek = 4;
            }

            Console.WriteLine($"VacationWeek: {vacationWeek}");
        }
    }
}