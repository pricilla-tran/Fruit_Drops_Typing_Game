using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WordManager : MonoBehaviour
{
    // Variables
    public List<Word> words;

    public WordSpawner wordSpawner;

    private bool hasActiveWord;
    private Word activeWord;
 
    // Adding the words 
    public void AddWord()
    {
        // Use Word Generator to get the words for the game
        Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
        // so we can see it on the console 
        //Debug.Log(word.word);

        // Add the words 
        words.Add(word);
    }

    // To control what letters need to be typed 
    public void TypeLetter(char letter) 
    { 
        if (hasActiveWord)
        {
            // Check if letter was next
                // Remove it from the word 
            if (activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }
        }
        else
        {
            // For Each loop to find the letters in the word
            foreach(Word word in words)
            {
                // if the letter typed matches the next letter 
                if (word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }

        // When word is completed and typed
        if (hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            // Remove the word
            words.Remove(activeWord);
            ScoreKeeper.instance.AddPoint();
        }
    } 
    
}
