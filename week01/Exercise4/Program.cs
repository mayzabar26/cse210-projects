using System;

//Step 1: Adding the collection
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Step 2: Adding the new object list operator
        List<int> numbers = new List<int>();

        //Step 3: Guess variable to store number
        int guessNum = -1;

        //Step 4: Loop and if statement
        while (guessNum != 0) //Loop until user types 0
        {
            Console.Write("Enter a list of numbers, type 0 when finished.");
            
            string userResponse = Console.ReadLine(); //Variable to store user response
            guessNum = int.Parse(userResponse); //The user answer is string, so we need to use parse to convert to int.

            //Only add number to the list, 0 is not part of it
            if (guessNum != 0) //If number is not 0, add to the list of numbers
            {
                numbers.Add(guessNum);
            }

        }
        //Step 5: Compute the sum
        int sum = 0; //Variable to store number to be sum
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        //Step 6: Compute the average
        float average = ((float)sum) / numbers.Count; //convert int to float because is division
        Console.WriteLine($"The average is: {average}");

        //Step 7: Find the bigger number
        int maxNumber = numbers[0]; //Zero is the reference to compare the other numbers from the list
        foreach (int number in numbers)
        {
            if(number > maxNumber) //If the current number is bigger than maxNumber, the maxNumber value is updated
            {
                maxNumber = number;
            }
        }
        Console.WriteLine($"The largest number is: {maxNumber}");
    }
}