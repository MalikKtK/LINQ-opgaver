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

        // Use the Where method to filter employees in the "Sales" department
        var salesEmployees = employees.Where(e => e.Department == "Sales");
        Console.WriteLine("Sales Employees:");
        foreach (var employee in salesEmployees)
        {
            Console.WriteLine($"{employee.Name,-15} | Department: {employee.Department,-10} | Salary: {employee.Salary:C}");
        }

        // Use the OrderBy method to sort by salary in ascending order
        var sortedBySalary = salesEmployees.OrderBy(e => e.Salary);
        Console.WriteLine("\nSales Employees Sorted by Salary (Ascending):");
        foreach (var employee in sortedBySalary)
        {
            Console.WriteLine($"{employee.Name,-15} | Department: {employee.Department,-10} | Salary: {employee.Salary:C}");
        }

        // Use the ThenBy method to sort by name in ascending order for employees with the same salary
        var sortedByName = sortedBySalary.ThenBy(e => e.Name);
        Console.WriteLine("\nSales Employees Sorted by Salary (Ascending) and Then by Name (Ascending):");
        foreach (var employee in sortedByName)
        {
            Console.WriteLine($"{employee.Name,-15} | Department: {employee.Department,-10} | Salary: {employee.Salary:C}");
        }

        // Use the First method to retrieve the first employee in the list
        var firstEmployee = sortedByName.First();
        Console.WriteLine($"\nFirst Employee: {firstEmployee.Name}");

        // Use the Last method to retrieve the last employee in the list
        var lastEmployee = sortedByName.Last();
        Console.WriteLine($"Last Employee: {lastEmployee.Name}");

        // Use the Count method to count the number of employees in the list
        var employeeCount = sortedByName.Count();
        Console.WriteLine($"Employee Count: {employeeCount}");

        // Use the Min method to find the minimum salary of all employees in the list
        var minSalary = sortedByName.Min(e => e.Salary);
        Console.WriteLine($"Minimum Salary: {minSalary:C}");

        // Use the Max method to find the maximum salary of all employees in the list
        var maxSalary = sortedByName.Max(e => e.Salary);
        Console.WriteLine($"Maximum Salary: {maxSalary:C}");

        Console.ReadLine();
    }
}

class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }
    public decimal Salary { get; set; }
}
