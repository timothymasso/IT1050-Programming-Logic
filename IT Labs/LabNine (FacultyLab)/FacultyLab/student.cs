using System;

public class Student : Person //Inheritance Step #1
{
    
    public string Id{get;set;}
    public string School{get;set;}
    public string Degree{get;set;}
    public string Major{get;set;}
    public double GPA{get;set;}
    
    public Student() : base() // Step #2
    {
        Id="Unknown";
        School = "Unknown";
        GPA=0.0;
    }
    
    public Student(string ssn, string name, string gender, DateTime dob, string id, string school, double gpa)
    :base(ssn, name, gender, dob) // Step #2
    {
        Id=id;
        School = school;
        GPA = gpa;
    }
    
    public override void Intro()//Step #3
    {
        base.Intro();//Step #4
        Console.WriteLine("I am a student");
        Console.WriteLine("Id="+Id);
        Console.WriteLine("School="+School);
        Console.WriteLine("GPA="+GPA);
    }
    
    
    
}