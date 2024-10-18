using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int countToHide = random.Next(1, 4);

        for (int i = 0; i < countToHide; i++)
        {
            int index = random.Next(words.Count);
            words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = string.Join(" ", words.Select(w => w.GetDisplayText()));
        return $"{reference.GetDisplayText()} {scriptureText}";
    }

    public int GetHiddenWordCount()
    {
        return words.Count(w => w.IsHidden());
    }

    public int GetTotalWordCount()
    {
        return words.Count;
    }
}
