using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _promptText = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something I did today that I am very happy about?",
        "What thing I did today that I will do differently tomorrow?"
    };

    private List<string> _usedPrompts = new List<string>();
    private Random _random = new Random();

    //Added codes so that prompts will not be repeated until all prompts had been used.
    public string GetRandomPrompt()
    {
        if (_promptText.Count == 0)
        {
            _promptText.AddRange(_usedPrompts);
            _usedPrompts.Clear();
        }
        int randomIndex = _random.Next(_promptText.Count);
        string randomPrompt = _promptText[randomIndex];

        _usedPrompts.Add(randomPrompt);
        _promptText.RemoveAt(randomIndex);

        return randomPrompt;
    }
}