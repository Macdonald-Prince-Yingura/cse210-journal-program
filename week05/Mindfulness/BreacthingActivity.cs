using System;

namespace MindfulnessProgram.Activities
{
    public class BreathingActivity : Activity
    {
        public override void Run()
        {
            DisplayStartMessage("Breathing", "This activity will help you relax by guiding you through slow breathing. Focus on your breath.");

            DateTime end = DateTime.Now.AddSeconds(duration);
            while (DateTime.Now < end)
            {
                Console.WriteLine("\nBreathe in...");
                ShowCountdown(4);
                Console.WriteLine("Breathe out...");
                ShowCountdown(6);
            }

            DisplayEndMessage("Breathing");
        }
    }
}
