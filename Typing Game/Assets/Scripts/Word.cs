using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word {

    // Set up intial variables 
    public string word;
    private int typeIndex;

    WordDisplay display;

    // Constructor
    public Word(string _word, WordDisplay _display) {

        word = _word;
        typeIndex = 0;

        display = _display;
        display.SetWord(word);
    }

    // To find the next letter we need in the active word
    public char GetNextLetter()
    {
        return word[typeIndex];
    }

    // Incrementing the typeIndex so we can find the needed letter
    public void TypeLetter()
    {
        typeIndex++;
        display.RemoveLetter();
    }

    // When the word is completed and typed
    public bool WordTyped()
    {
        bool wordTyped = (typeIndex >= word.Length);
        if (wordTyped)
        {
            // Remove word from the screen
            display.RemoveWord();
        }
        return wordTyped;
    }
}
