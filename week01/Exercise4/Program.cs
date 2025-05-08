using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to stop): ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Part 1: Calculate the sum

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum of the numbers is: {sum}");

        //Part 2: Calculate the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average of the numbers is: {average}");

        // Part 3: Find the maximum number

        int maxNumber = numbers[0];
        foreach (int number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }
        Console.WriteLine($"The maximum number is: {maxNumber}");

        // Part 4: Find the minimum positive number
        int minPositiveNumber = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < minPositiveNumber)
            {
                minPositiveNumber = number;
            }
        }
        if (minPositiveNumber == int.MaxValue)
        {
            Console.WriteLine("There are no positive numbers in the list.");
        }
        else
        {
            Console.WriteLine($"The minimum positive number is: {minPositiveNumber}");
        }


        // Part 5: Sort the numbers in ascending order
        numbers.Sort();
        Console.WriteLine("The numbers in ascending order are: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}