using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Employee
    {
        private List<int> grades = new List<int>();
        public Employee(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public string name { get; private set; }
        public string surname { get; private set; }
        public int age { get; private set; }

        public void AddGrade(int grade)
        {
            this.grades.Add(grade);
        }

        public int TotalGradesForEmployee
        {
            get
            {
                return this.grades.Sum();
            }
        }

    }

}
