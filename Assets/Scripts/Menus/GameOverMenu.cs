using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverMenu : MonoBehaviour
{

    public GameObject gameOver;
    public GameObject WinningScreen;
    //public PlayerController playerScore;
     public bool isActive;
     
    public static bool bossy;
    [SerializeField] private Text timer;
    public TimeCounter timmmy;
    public int score =100;
    // Start is called before the first frame update
    void Start()
    {
        gameOver.SetActive(false);
        WinningScreen.SetActive(false);
        isActive = false;
     
    }

    // Update is called once per frame
    void Update()
    {
      if(score <= 0)
        {
            
            stopGame();
          //  Incoming = null;
            isActive = true;
            bossy = true;
            
        }

        if (GameManager.enter == true)
        {
            endGame();
            isActive = true;
          
          //  Debug.Log("wtf");
        }

        if (Level1Manager.goaway2 == true)
        {
            endGame();
            isActive = true;
        //    Debug.Log("wtf");
        }

    }

  
    
    public void restartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main");
        //gameOver.SetActive(false);
        score = 100;
        isActive = false;
    }

    public void restartGame2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainLevel2");
        //gameOver.SetActive(false);
        score = 100;
        isActive = false;
        bossy =false;
    }

    public void stopGame()
    {
        gameOver.SetActive(true);
        bossy = true;
        timer.text = timmmy.timer.ToString();
        Time.timeScale = 0f;
        
    }

    public void endGame()
    {
        WinningScreen?.SetActive(true);
        timer.text = timmmy.timer.ToString();
        Time.timeScale = 0f;
        //Debug.Log("why");
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("MenuScreen");
        //WinningScreen.SetActive(false);
       // MenuScreen.run = true;
    }

   


}