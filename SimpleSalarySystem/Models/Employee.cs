using System.ComponentModel.DataAnnotations;

namespace SimpleSalarySystem.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal HourlyRate { get; set; }
        public int HoursWorked { get; set; }
        public decimal Tax { get; set; }
        public decimal SSS { get; set; }
        public decimal PagIbig { get; set; }
        public decimal TotalSalary { get; set; }

        // Fixed deduction values
        private const decimal TaxRate = 0.10m; // 10% tax
        private const decimal SSSDeduction = 500m; // Fixed SSS
        private const decimal PagIbigDeduction = 200m; // Fixed PagIbig

        public void CalculateTotalSalary()
        {
            decimal grossSalary = HourlyRate * HoursWorked;
            Tax = grossSalary * TaxRate;
            SSS = SSSDeduction;
            PagIbig = PagIbigDeduction;

            decimal deductions = Tax + SSS + PagIbig;
            TotalSalary = grossSalary - deductions;

        }
    }
}