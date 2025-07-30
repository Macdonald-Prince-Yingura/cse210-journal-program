using System;
using MindfulnessProgram.Activities;

class Program
{
    static void Main(string[] args)
    {
        int sessionsCompleted = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");
            string input = Console.ReadLine();

            Activity activity = input switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectingActivity(),
                "3" => new ListingActivity(),
                "4" => null,
                _ => null
            };

            if (input == "4") break;

            if (activity != null)
            {
                activity.Run();
                sessionsCompleted++;
            }
        }

        Console.WriteLine($"\nTotal sessions completed: {sessionsCompleted}");
        Console.WriteLine("Thank you for using the Mindfulness Program!");
    }
}
