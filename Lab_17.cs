using System;

interface IResult
{
    bool Pass(int mark);
}

interface IDivision
{
    string Division(int average);
}

class Student : IResult, IDivision
{
    public bool Pass(int mark)
    {
        return mark >= 50;
    }

    public string Division(int average)
    {
        if (average >= 60)
            return "First Division";
        else if (average >= 50)
            return "Second Division";
        else
            return "No Division";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();

        Console.WriteLine(s.Pass(55));
        Console.WriteLine(s.Division(58));
    }
}