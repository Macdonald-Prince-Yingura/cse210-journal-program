using System;
using System.Collections.Generic;

namespace MindfulnessProgram.Activities
{
    public class ReflectingActivity : Activity
    {
        private readonly List<string> prompts = new()
        {
            "Think of a time when you stood up for someone.",
            "Think of a time when you did something difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you were truly selfless."
        };

        private readonly List<string> questions = new()
        {
            "Why was this experience meaningful?",
            "Have you done anything like this before?",
            "How did you feel after it was done?",
            "What did you learn about yourself?",
            "How can you apply this experience in the future?"
        };

        public override void Run()
        {
            DisplayStartMessage("Reflecting", "This activity will help you reflect on times of strength and resilience.");

            Random rand = new();
            Console.WriteLine("\n" + prompts[rand.Next(prompts.Count)]);
            ShowSpinner(4);

            DateTime end = DateTime.Now.AddSeconds(duration);
            while (DateTime.Now < end)
            {
                Console.WriteLine("> " + questions[rand.Next(questions.Count)]);
                ShowSpinner(5);
            }

            DisplayEndMessage("Reflecting");
        }
    }
}
