public class Employee
{
    public string firstname;
    public string lastname;
    public string id;
    public int age;
    public double yearlysalary;
    public string employmentstatus;

    public Employee()
    {
        firstname = "Unknown";
        lastname = "Unknown";
        id = "Unknown";
        age = 0;
        employmentstatus = "active";
    }

    public Employee(string e_fname, string e_lname, string e_id, int e_age)
    {
        firstname = e_fname;
        lastname = e_lname;
        id = e_id;
        age = e_age;
        employmentstatus = "active";
    }

    public void Intro()
    {
        System.Console.WriteLine(firstname);
        System.Console.WriteLine(lastname);
        System.Console.WriteLine(id);
        System.Console.WriteLine(age);
        System.Console.WriteLine(employmentstatus);
    }
}

