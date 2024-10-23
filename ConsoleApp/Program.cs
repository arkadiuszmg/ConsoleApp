using ConsoleApp;
using System.Threading.Tasks.Sources;

Employee emp1 = new Employee("Tomasz", "Nowak", 27);
Employee emp2 = new Employee("Marek", "Kowalski", 33);
Employee emp3 = new Employee("Łukasz", "Bąk", 30);

emp1.AddGrade(5);
emp1.AddGrade(7);
emp1.AddGrade(6);
emp1.AddGrade(9);
emp1.AddGrade(6);


emp2.AddGrade(4);
emp2.AddGrade(2);
emp2.AddGrade(4);
emp2.AddGrade(10);
emp2.AddGrade(7);


emp3.AddGrade(9);
emp3.AddGrade(7);
emp3.AddGrade(6);
emp3.AddGrade(8);
emp3.AddGrade(8);

List<Employee> employeeList = new List<Employee>()
{
    emp1, emp2, emp3
};

int maxGrade = -1;
Employee employeeWithMaxResult = null;

foreach (Employee employee in employeeList)
{
    if (employee.TotalGradesForEmployee > maxGrade)
    {
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine($"The best worker is: {employeeWithMaxResult.name} {employeeWithMaxResult.surname}. With result: {employeeWithMaxResult.TotalGradesForEmployee}");

