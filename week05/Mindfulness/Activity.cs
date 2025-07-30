using System;
using System.Threading;

namespace MindfulnessProgram.Activities
{
    public class Activity
    {
        protected int duration;

        protected void DisplayStartMessage(string name, string description)
        {
            Console.Clear();
            Console.WriteLine($"--- {name} Activity ---");
            Console.WriteLine(description);
            Console.Write("\nEnter duration in seconds: ");
            duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Get ready to begin...");
            ShowSpinner(3);
        }

        protected void DisplayEndMessage(string name)
        {
            Console.WriteLine("\nWell done!");
            ShowSpinner(2);
            Console.WriteLine($"You have completed the {name} Activity for {duration} seconds.");
            ShowSpinner(3);
        }

        protected void ShowSpinner(int seconds)
        {
            for (int i = 0; i < seconds * 4; i++)
            {
                Console.Write("\\|/-"[i % 4]);
                Thread.Sleep(250);
                Console.Write("\b");
            }
        }

        protected void ShowCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"{i} ");
                Thread.Sleep(1000);
                Console.Write("\b\b");
            }
            Console.WriteLine();
        }

        public virtual void Run() { }
    }
}
