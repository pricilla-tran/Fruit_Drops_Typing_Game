using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    // Array for all the words that can be picked
    private static string[] wordList = { "apple", "banana", "orange", "lychee", "kumquat", "lemon", "lime", "pear", "avocado", "grapes", "strawberry", "peach", "dragonfruit", "watermelon"};

    // Random Word Generator
    public static string GetRandomWord() 
    {
        // pick a random index for the word
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}
