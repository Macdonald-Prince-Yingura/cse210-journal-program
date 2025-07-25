using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> prompts = new List<string>()
    {
        "What was the best part of your day?",
        "What did you learn today?",
        "What is something you're grateful for?",
        "Describe a challenge you faced today.",
        "What is something you want to improve?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        return prompts[index];
    }
}
