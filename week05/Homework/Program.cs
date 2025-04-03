using System;

class Program
{
    static void Main(string[] args)
    {
        //Create "Assignment" class objects
        Assignment a1 = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        //Create "MathAssignment" objects
        MathAssignment a2 = new MathAssignment("Marjorie Blossom", "Arts", "4.5", "1-10");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        //Create "WritingAssignment" objects
        WritingAssignment a3 = new WritingAssignment("Jason Cooper", "American Literature", "Fahrenheit 451");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}