using System;

class Student
{
    int rollNo;
    string name;
    double marks;

    public Student()
    {
        rollNo = 0;
        name = "Unknown";
        marks = 0;
    }

    public Student(int r, string n, double m)
    {
        rollNo = r;
        name = n;
        marks = m;
    }

    public string CalculateGrade()
    {
        if (marks >= 90) return "A";
        else if (marks >= 75) return "B";
        else if (marks >= 60) return "C";
        else if (marks >= 50) return "D";
        else return "F";
    }

    public void Display()
    {
        Console.WriteLine("Roll No: " + rollNo);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Marks: " + marks);
        Console.WriteLine("Grade: " + CalculateGrade());
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student();
        s1.Display();

        Student s2 = new Student(1, "Abhinash", 82);
        s2.Display();
    }
}