using System;

public class Scripture 
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] wordStrings = text.Split(' ');

        // Iterate through the string and chop it up based 
        // on where the spaces are to seperate each word. 
        foreach (string wordString in wordStrings)
        {
            _words.Add(new Word(wordString));
        }
    }

    public void HideRandomWords(int numberToHide){
        Random randomGenerator = new Random();
        List<int> usedNumbers = new List<int>();
        // int randomNumber = 0;
        for (int i = 0; i < numberToHide; i++)
        {
            int randomNumber = randomGenerator.Next(0, _words.Count);
            while (usedNumbers.Contains(randomNumber))
            {
                randomNumber = randomGenerator.Next(0, _words.Count);
            }
            usedNumbers.Add(randomNumber);
            _words[randomNumber].Hide();
        }
    }

    public string GetDisplayText(){
        string displayText = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.TrimEnd();
    }

    public bool IsCompletelyHidden()
    {
        // Check if the whole passage is hidden.
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

}