using System;

class Student
{
    public string Name;
}

class StudentPrinter
{
    public void Print(Student s)
    {
        Console.WriteLine("Student Name: " + s.Name);
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        s.Name = "Rahul";

        StudentPrinter p = new StudentPrinter();
        p.Print(s);
    }
}