using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER!!");
            LoseState();
        }
       
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    void LoseState()
    {
        SceneManager.LoadScene("LoseScene");
        ScoreKeeper.instance.TallyPoints();
    }

}
