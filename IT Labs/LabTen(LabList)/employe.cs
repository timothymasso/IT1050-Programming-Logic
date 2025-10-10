using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    
    string Id {get; set;}
    string Firstname {get; set;}
    string Lastname {get; set;}
    string Address {get; set;}
    string Title {get; set;}
    DateTime JoiningDate {get; set;}
    bool IsActive{ get; set;}
    
    public Employee()
    {
        IsActive = true;
    }
    
    public Employee(string id, string fname, string lname, string title)
    {
        Id = id;
        Firstname = fname;
        Lastname = lname;
        Title = title;
        IsActive = true;
    }
    
    public void Intro()
    {
        Console.WriteLine("Employee first name: {0} last name: {1} title: {2} currentStatus : {3}", Firstname, Lastname, Title, IsActive);
    }
    
    
    
}