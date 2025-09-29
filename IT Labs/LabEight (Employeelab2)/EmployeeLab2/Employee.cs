using System;

class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    private int age;
    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 18)
                age = value;
            else
                Console.WriteLine("Age cannot be less than 18.");
        }
    }

    private double yearlySalary;
    public double YearlySalary
    {
        get { return yearlySalary; }
        set
        {
            if (value >= 1000)
                yearlySalary = value;
            else
                Console.WriteLine("YearlySalary cannot be less than $1000.");
        }
    }

    public string Id { get; set; }
    public string EmploymentStatus { get; set; }

    public Employee()
    {
        FirstName = "Unknown";
        LastName = "Unknown";
        Id = "Unknown";
        Age = 0;
        YearlySalary = 0;
        EmploymentStatus = "active";
    }

    public Employee(string fName, string lName, string id, int age)
    {
        FirstName = fName;
        LastName = lName;
        Id = id;
        Age = age;
        YearlySalary = 0;
        EmploymentStatus = "active";
    }

    public void Intro()
    {
        Console.WriteLine("Employee details:");
        Console.WriteLine("First Name : " + FirstName);
        Console.WriteLine("Last Name : " + LastName);
        Console.WriteLine("Id : " + Id);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Yearly Salary: $" + YearlySalary);
        Console.WriteLine("Employment Status: " + EmploymentStatus);
        Console.WriteLine();
    }

    public void IncreaseSalary(double percent)
    {
        if (percent < 0)
        {
            Console.WriteLine("percentage is invalid");
            return;
        }
        Console.WriteLine("percentage is valid");
        YearlySalary = YearlySalary + (YearlySalary * percent);
    }

    public void RemoveEmployee()
    {
        if (EmploymentStatus == "inactive")
            Console.WriteLine("Employee already inactive");
        else
        {
            EmploymentStatus = "inactive";
            Console.WriteLine("Employee removed");
        }
    }
}
