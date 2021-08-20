using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WordDisplay : MonoBehaviour
{
    public Text text;
    public float fallSpeed = 1f;

    public void SetWord(string word)
    {
        text.text = word; 
    }

    public void RemoveLetter()
    {
        text.text = text.text.Remove(0, 1);
        text.color = Color.blue; 
    }

    public void RemoveWord()
    {
        Destroy(gameObject);
    }

    private void FixedUpdate()
    {
        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
        if (transform.position.y < -4f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
