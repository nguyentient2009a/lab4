using System;
using Part4.Part4;

namespace Part4
{
    public class Faculty : Employee
    {
        public string OfficeHours { get; set; }
        public string Rank { get; set; }
        
        public override void CalculateBonus()
        {
            double bonus = 0.06 * Salary;
            Console.WriteLine($"Bonus: {bonus}");
        }

        public override void CalculateVacation()
        {
            int vacationWeek = 4;
            if (DateHired > 1095)
            {
                vacationWeek = 5;
            }

            if (Rank == "Senior Lecturer")
            {
                vacationWeek += 1;
            }

            Console.WriteLine($"VacationWeek : {vacationWeek}");
        }
    }
}