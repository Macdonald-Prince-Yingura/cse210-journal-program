using System;
using System.Collections.Generic;

namespace MindfulnessProgram.Activities
{
    public class ListingActivity : Activity
    {
        private readonly List<string> prompts = new()
        {
            "Who are people you appreciate?",
            "What are your personal strengths?",
            "What are some blessings in your life?",
            "Who did you help this week?",
            "Who are your personal heroes?"
        };

        public override void Run()
        {
            DisplayStartMessage("Listing", "This activity will help you list positive things in your life.");

            Random rand = new();
            Console.WriteLine("\n" + prompts[rand.Next(prompts.Count)]);
            Console.WriteLine("Start listing in:");
            ShowCountdown(5);

            List<string> items = new();
            DateTime end = DateTime.Now.AddSeconds(duration);
            while (DateTime.Now < end)
            {
                Console.Write("> ");
                string response = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(response))
                    items.Add(response);
            }

            Console.WriteLine($"\nYou listed {items.Count} item(s).");
            DisplayEndMessage("Listing");
        }
    }
}
