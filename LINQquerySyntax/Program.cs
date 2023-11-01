using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>()
        {
            // Add at least 10 employees here
            new Employee { Name = "Malik", Department = "Sales", Salary = 50000 },
            new Employee { Name = "Ebubekir", Department = "HR", Salary = 60000 },
            new Employee { Name = "Haci", Department = "Sales", Salary = 55000 },
            new Employee { Name = "Mark", Department = "IT", Salary = 70000 },
            new Employee { Name = "Daniel", Department = "Sales", Salary = 52000 },
            new Employee { Name = "Jens", Department = "Marketing", Salary = 62000 },
            new Employee { Name = "Bøfhus", Department = "Sales", Salary = 53000 },
            new Employee { Name = "Peter", Department = "Sales", Salary = 54000 },
            new Employee { Name = "Lars", Department = "IT", Salary = 71000 },
            new Employee { Name = "Emilie", Department = "Sales", Salary = 51000 }
        };

        // LINQ query to find all employees who work in the "Sales" department
        var salesEmployees = from employee in employees
                             where employee.Department == "Sales"
                             select employee;

        Console.WriteLine("Sales Employees:");
        foreach (var employee in salesEmployees)
        {
            Console.WriteLine($"{employee.Name,-15} | Department: {employee.Department,-10} | Salary: {employee.Salary:C}");
        }

        // LINQ query to sort the employees by salary in ascending order
        var sortedBySalary = from employee in salesEmployees
                             orderby employee.Salary
                             select employee;

        Console.WriteLine("\nSales Employees Sorted by Salary (Ascending):");
        foreach (var employee in sortedBySalary)
        {
            Console.WriteLine($"{employee.Name,-15} | Department: {employee.Department,-10} | Salary: {employee.Salary:C}");
        }

        // LINQ query to sort the employees by name in ascending order for employees with the same salary
        var sortedByName = from employee in sortedBySalary
                           orderby employee.Name
                           select employee;

        Console.WriteLine("\nSales Employees Sorted by Salary (Ascending) and Then by Name (Ascending):");
        foreach (var employee in sortedByName)
        {
            Console.WriteLine($"{employee.Name,-15} | Department: {employee.Department,-10} | Salary: {employee.Salary:C}");
        }

        // LINQ query to find all names of the employees in the “Sales” department
        var salesEmployeeNames = from employee in employees
                                 where employee.Department == "Sales"
                                 select employee.Name;

        Console.WriteLine("\nNames of Employees in the Sales Department:");
        foreach (var name in salesEmployeeNames)
        {
            Console.WriteLine(name);
        }

        Console.ReadLine();
    }
}

class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }
    public decimal Salary { get; set; }
}
