using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public static ScoreKeeper instance;
    int score = 0;
    int finalScore = 0;
    public Text scoreText;
    //public Text finalScoreText;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        finalScore = PlayerPrefs.GetInt("finalScore", 0);
        scoreText.text = score.ToString();
        //finalScoreText.text = "FINAL SCORE: " + finalScore.ToString();
    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString();
        PlayerPrefs.SetInt("finalScore", score);
    }

    public void TallyPoints()
    {
        PlayerPrefs.SetInt("finalScore", score);
    }
    
}
