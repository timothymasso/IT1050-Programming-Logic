using System;

public class Faculty : Person
{
    public string Id { get; set; }
    public string Title { get; set; } 
    public DateTime DateOfEmployment { get; set; } 
    public string Employer { get; set; }
    public decimal YearlySalary { get; set; }
    public bool Tenured { get; set; } 

    public Faculty() : base()
    {
        Id = "Unknown";
        Title = "Instructor";
        Employer = "Unknown";
        YearlySalary = 0.0m;
        Tenured = false;
    }

    public Faculty(string firstName, string lastName) : base()
    {
        Name = firstName + " " + lastName;
        Id = "Unknown";
        Title = "Instructor";
        Employer = "Unknown";
        YearlySalary = 0.0m;
        Tenured = false;
    }

    public Faculty(string ssn, string name, string gender, DateTime dob, string id, string title, DateTime dateOfEmployment, string employer, decimal yearlySalary, bool tenured)
        : base(ssn, name, gender, dob)
    {
        Id = id;
        Title = title;
        DateOfEmployment = dateOfEmployment;
        Employer = employer;
        YearlySalary = yearlySalary;
        Tenured = tenured;
    }

    public bool GrantTenure()
    {
        int yearsWorked = DateTime.Today.Year - DateOfEmployment.Year;
        if (DateOfEmployment > DateTime.Today.AddYears(-yearsWorked)) yearsWorked--;
        if (yearsWorked >= 5)
            Tenured = true;
        else
            Tenured = false;
        return Tenured;
    }

    public bool Promote()
    {
        int yearsWorked = DateTime.Today.Year - DateOfEmployment.Year;
        if (DateOfEmployment > DateTime.Today.AddYears(-yearsWorked)) yearsWorked--;
        if (Title == "Instructor" && yearsWorked > 2)
        {
            Title = "Assistant Professor";
            Console.WriteLine("Faculty promoted to Assistant Professor rank");
            return true;
        }
        else if (Title == "Assistant Professor" && yearsWorked > 5)
        {
            Title = "Associate Professor";
            Console.WriteLine("Faculty promoted to Associate Professor rank");
            return true;
        }
        else if (Title == "Associate Professor" && yearsWorked > 10)
        {
            Title = "Professor";
            Console.WriteLine("Faculty promoted to Professor rank");
            return true;
        }
        else if (Title == "Professor")
        {
            Console.WriteLine("No more promotion possible");
            return false;
        }
        return false;
    }

    public override void Intro()
    {
        base.Intro();
        string tenureStatus = Tenured ? "and I am tenured" : "and I am not tenured";
        Console.WriteLine($"I work as {Title} at {Employer} since {DateOfEmployment.Year} {tenureStatus}");
    }
}
