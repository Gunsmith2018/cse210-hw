/* This will prompt the user with questions that spark thought. */
using System;
using System.Collections.Generic;


public class PromptGenerator
{
    string[] strArray = new string[]
    {
        "What made you smile today?",
        "Describe a moment you felt proud.",
        "What do you want to achieve this week?",
        "What’s something you’re grateful for right now?",
        "What’s a challenge you overcame recently?"
    };
    public void DisplayPrompts()
    {
        foreach (string str in strArray)
        {
            Console.WriteLine(str);
        }
    }
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(strArray.Length);
        return strArray[index];
    }

}