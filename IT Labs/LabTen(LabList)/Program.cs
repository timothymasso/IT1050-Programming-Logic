using System;

class Program
{
  static void Main() {
    Employee e1 = new Employee("101", "Alice", "Johnson", "Developer");
    Employee e2 = new Employee("102", "Bob", "Smith", "HR Rep");
    Employee e3 = new Employee("103", "Charlie", "Brown", "Analyst");
    Employee e4 = new Employee("104", "Diana", "Prince", "Marketing");
    Employee e5 = new Employee("105", "Evan", "Davis", "Engineer");
    Employee e6 = new Employee("106", "Fiona", "Green", "SalesRep");

    EmployeeManager em1 = new EmployeeManager();
    EmployeeManager em2 = new EmployeeManager();

    em1.AddEmployee(e1);
    em1.AddEmployee(e2);
    em1.AddEmployee(e3);
    Console.WriteLine("\nEmployee Manager #1 - All Employees:");
    em1.DisplayEmployees();

    if (em1.UpdateEmployee("102", "HR Rep2"))
      Console.WriteLine("Employee 102 title updated to HR Rep2.");
    else
      Console.WriteLine("Employee 102 not found.");

    if (em1.RemoveEmployee("101"))
      Console.WriteLine("Employee 101 removed.");
    else
      Console.WriteLine("Employee 101 not found.");

    Console.WriteLine("\nEmployee Manager #1 - After Update/Remove:");
    em1.DisplayEmployees();

    em2.AddEmployee(e4);
    em2.AddEmployee(e5);
    em2.AddEmployee(e6);
    Console.WriteLine("\nEmployee Manager #2 - All Employees:");
    em2.DisplayEmployees();

    if (em2.UpdateEmployee("105", "HR Rep2"))
      Console.WriteLine("Employee 105 title updated to HR Rep2.");
    else
      Console.WriteLine("Employee 105 not found.");

    if (em2.RemoveEmployee("106"))
      Console.WriteLine("Employee 106 removed.");
    else
      Console.WriteLine("Employee 106 not found.");

    Console.WriteLine("\nEmployee Manager #2 - After Update/Remove:");
    em2.DisplayEmployees();
  }
}