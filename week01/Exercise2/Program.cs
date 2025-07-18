using System;

class Program
{
    static void Main()
    {
        // Ask for user input
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int gradePercentage = int.Parse(input);

        string letter = "";
        string sign = "";

        // Determine base letter grade
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine + or - sign, if applicable
        int lastDigit = gradePercentage % 10;

        if (letter != "A" && letter != "F") // A+ and F+/- are not allowed
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Output full grade
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Determine pass/fail
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't worry. Keep working hard and you'll do better next time!");
        }
    }
}
