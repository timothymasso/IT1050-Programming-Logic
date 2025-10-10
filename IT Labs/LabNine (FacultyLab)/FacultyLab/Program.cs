using System;

class Program
{
    static void Main() 
    {
        Console.WriteLine("Inheritance");
        
        Person p1 = new Person("111", "Person1", "F", Convert.ToDateTime("01/01/1976"));
        p1.Intro();
        p1.IsBirthday();
        
        Student s1 = new Student("222", "Student1", "M", Convert.ToDateTime("01/01/1996"), 
                               "S1234", "Tri-C", 3.5);
        s1.Intro();
        s1.IsBirthday();
    }
}

