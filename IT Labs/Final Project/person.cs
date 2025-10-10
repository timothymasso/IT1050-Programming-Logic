using System;

public class Person{
    
 private string ssn;
 public string SSN{
     
     get
     {
       return ssn;   
     }
     
     set{
         
         if (value.Length==9)
            ssn = value;
        else
            Console.WriteLine("Invalid ssn. Length not equal to 9");
     }
     
     
 }
 public string Name{get;set;}
 public string Address{get;set;}
 public string Gender{get;set;}
 public DateTime DateOfBirth{get;set;}
 
 //Constructor
 public Person(){
     SSN="999999999";
     Name="Unknown";
     Address="Unknown";
     Gender="X";
 }
 
 //Constructor w/parameters
 public Person(string ssn, string name, string gender, DateTime dob){
     SSN=ssn;
     Name=name;
     Address="Unknown";
     Gender=gender;
     DateOfBirth = dob;
 }
    
 public virtual void Intro(){ //Step #3
     Console.WriteLine("Hello I am a person named "+ Name);
     Console.WriteLine("SSN="+ SSN);
     Console.WriteLine("Date Of Birth="+ DateOfBirth);
     Console.WriteLine("Gender="+Gender);
     Console.WriteLine("Address="+Address);
 }    
    
}