using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace System_School.Models
{
    public class Student(string name, string lastName, string documentType, string documentNumber, string email, string address, string phone, string nameGuardian, string currentCourse, DateOnly fechaNacimiento, List<double> grades) : Person(name, lastName, documentType, documentNumber, email, phone)
    {
        public string NameGuardian { get; set; } = nameGuardian;
        public string CurrentCourse { get; set; } = currentCourse;
        public DateOnly FechaNacimiento { get; set; } = fechaNacimiento;
        public string Address { get; set; } = address;
        public List<double> Grades { get; set; } = grades;

        public void AddGrade(List<double> grades)
        {
            double newGrade = Setting.InputDouble("Enter your new Rating => ");

            Grades.Add(newGrade);
            Console.WriteLine("");
            Console.WriteLine("Grade added successfully!");
            Console.WriteLine("");

            Setting.FinishOption();
        }

        private void CalculateAverage(List<double> grades)
        {
            double average = 0;

            foreach (double grade in grades)
            {
                average += grade;
            }

            average /= Grades.Count;

            Console.WriteLine(@$"
                Name:  + {Name}
                Average: {average}
            ");
            
            Setting.FinishOption();
        }

        public int CalculateAge(DateOnly fechaNacimiento)
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);
            int age = today.Year - fechaNacimiento.Year;

            if (today < fechaNacimiento.AddYears(age))
            {
                age--;
            }
            return age;
        }

    }
}