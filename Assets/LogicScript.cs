using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreTxet;
    public GameObject gameOverScreen;


    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore =playerScore + scoreToAdd;
        scoreTxet.text  = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }


    
}
