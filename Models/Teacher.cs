using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace System_School.Models
{
    public class Teacher(string name, string lastName, string documentType, string documentNumber, string email, string phone, string subject, double salary, DateTime hiringDate) : Person(name, lastName, documentType, documentNumber, email, phone)
    {
        public string Subject { get; set; } = subject;
        public double Salary { get; set; } = salary;
        public DateTime HiringDate { get; set; } = hiringDate;
        public List<string> Courses { get; set; } = new List<string>();

        public void GetSalary()
        {
            Console.WriteLine($"Salary: {Salary}");
        }

        public int CalculateSeniority()
        {
            DateTime today = DateTime.Now;
            int seniority = today.Year - HiringDate.Year;

            if (today < HiringDate.AddYears(seniority))
            {
                seniority--;
            }
            return seniority;
        }
    }
}