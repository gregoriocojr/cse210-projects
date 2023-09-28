using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Words> _words;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
    }

    public void HideRandomWords(int numberToHide)
    {
        Console.WriteLine(_words);
    }

    public string GetDisplayText()
    {
        return ($"{_reference.GetDisplayText()} {_words}");
    }

    public bool IsCompletelyHidden()
    {
        int length = _words.Count;
        return true; 
    }
}