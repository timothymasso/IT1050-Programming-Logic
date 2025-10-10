using System;
using System.Collections.Generic;

class EmployeeManager
{
    public List<Employee> DirectReportList { get; set; }
    public string Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Title { get; set; }

    public EmployeeManager()
    {
        DirectReportList = new List<Employee>();
    }

    public void AddEmployee(Employee employee)
    {
        DirectReportList.Add(employee);
        Console.WriteLine($"Employee {employee.Id} added successfully.");
    }

    public void DisplayEmployees()
    {
        if (DirectReportList.Count == 0)
        {
            Console.WriteLine("No employees found.");
            return;
        }
        Console.WriteLine("ID\tFirst Name\tLast Name\tTitle");
        foreach (var emp in DirectReportList)
        {
            Console.WriteLine($"{emp.Id}\t{emp.Firstname}\t{emp.Lastname}\t{emp.Title}");
        }
    }

    public Employee SearchEmployee(string id)
    {
        foreach (var emp in DirectReportList)
        {
            if (emp.Id == id)
                return emp;
        }
        return null;
    }

    public bool UpdateEmployee(string id, string newTitle)
    {
        var emp = SearchEmployee(id);
        if (emp != null)
        {
            emp.Title = newTitle;
            return true;
        }
        return false;
    }

    public bool RemoveEmployee(string id)
    {
        var emp = SearchEmployee(id);
        if (emp != null)
        {
            DirectReportList.Remove(emp);
            return true;
        }
        return false;
    }
}
