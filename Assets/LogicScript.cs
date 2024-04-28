using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreTxt;
    public GameObject gameOverScreen;
    public Button playAgainButt;
    
    public void AddScore(int scoreToAdd) 
    {
        playerScore = playerScore + scoreToAdd;
        scoreTxt.text = playerScore.ToString();
    
    }
    [ContextMenu("Increase score")]
    public void AddOneScore()
    {
        playerScore = playerScore + 1;
        scoreTxt.text = playerScore.ToString();

    }
    public void buttonOn()
    {
        
        playAgainButt.interactable=true;
    }
    public void restartGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    
    }
    public void gameOver() 
    {
        gameOverScreen.SetActive(true);
    }
    public void quitGame() 
    {
        Application.Quit();
    }
}
