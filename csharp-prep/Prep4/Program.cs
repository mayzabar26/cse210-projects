using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        //While loop here
        int userNumber = -1;
        while(userNumber !=0)
        {
            //Asking the user for a number
            Console.Write("Enter a list o numbers, type 0 when finished.");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        //Computing the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        //Computing the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}.");

        //Finding the max number
        float maxNumber = numbers[0];
        foreach (float number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }
        Console.WriteLine($"The max number is: {maxNumber}");
    }    
}