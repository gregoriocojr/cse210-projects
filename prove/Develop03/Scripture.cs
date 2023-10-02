using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(wordText => new Word(wordText)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        if (_words.Count <= numberToHide)
        {
            foreach (var word in _words)
            {
                word.Hide();
            }
        }
        else
        {
            Random random = new Random();

            var hiddenIndices = new HashSet<int>();
            while (hiddenIndices.Count < numberToHide)
            {
                int randomIndex;
                do
                {
                    randomIndex = random.Next(_words.Count);
                }
                while (hiddenIndices.Contains(randomIndex));

                hiddenIndices.Add(randomIndex);
                _words[randomIndex].Hide();
            }
        }
    }

    public string GetDisplayText()
    {
        string displayText = string.Join(" ", _words.Select(word => word.IsHidden() ? new string('_', word.GetDisplayText().Length) : word.GetDisplayText()));
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}