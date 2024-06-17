using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.Services.CloudSave.Models;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverMenu : MonoBehaviour
{

    public GameObject gameOver;
    public GameObject WinningScreen;
    //public PlayerController playerScore;
     public bool isActive;
     int num = 0;
    public static bool bossy;
    [SerializeField] private Text timer;
    public TimeCounter timmmy;
    public int score =100;
   public static int saveScore;
    public static bool isDead;
   
   
   
    // Start is called before the first frame update
    void Start()
    {
       
        gameOver.SetActive(false);
        WinningScreen.SetActive(false);
        isActive = false;
        AudioManager.instance.musicSource.Play();
      
       

    }

    // Update is called once per frame
    void Update()
    {
        
        if (score <= 0)
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
        AudioManager.instance.musicSource.Play();
        //gameOver.SetActive(false);
        score = 100;
        isActive = false;
       
    }

    public void restartGame2()
    {
        Time.timeScale = 1f;
        isDead = false;
        AudioManager.instance.musicSource.Play();
        SceneManager.LoadScene("MainLevel2");
        //gameOver.SetActive(false);
        score = 100;
        GlobalPoints.Instance.Reset();
        PointManager.points = GlobalPoints.Instance.getPoints();
        LoopCounter.Instance.Reset();
        PointManager.LoopPoints3 = LoopCounter.Instance.getPoints();
       
        TimeManager.Instance.Reset();
        
        isActive = false;
        bossy =false;
        try
        {
            HighScoreScript.startdata();
        }
        catch
        {
            Debug.Log("Player Not Loaded");
        }

    }

    public  async void stopGame()
    {
        isDead = true;
       AudioManager.instance.musicSource.Stop();
      
        
        gameOver.SetActive(true);
            bossy = true;
            timer.text = timmmy.timer.ToString();
            Time.timeScale = 0f;
            



        if (HighScoreScript.num < PointManager.points)
        {
            try
            {
                await CloudSave.SaveData();
                Item temp = await CloudSave.LoadData();
                HighScoreScript.num = temp.Value.GetAs<int>();
                Debug.Log(HighScoreScript.num.ToString());
            }

            catch
            {
                Debug.Log("no internet");
            }
            
                
                
           
        }
        if (HighScoreScript.num2 < PointManager.LoopPoints3)
        {
            try
            {
                await CloudSave.SaveLoops();
                Item temp = await CloudSave.LoadLoops();
                HighScoreScript.num2 = temp.Value.GetAs<int>();
                Debug.Log(HighScoreScript.num2.ToString());
            }
            

             catch
            {
                Debug.Log("no internet");
            }
        }
         
        if(HighScoreScript.num3 < TimeManager.Instance.GetTme())
        {
            if (TimeManager.Instance.GetTme() != 0)
            {
                try
                {
                    await CloudSave.SaveTime();
                    Item temp = await CloudSave.LoadTime();
                    HighScoreScript.num3 = temp.Value.GetAs<int>();
                    Debug.Log(HighScoreScript.num3.ToString());
                }
                

                 catch
            {
                    Debug.Log("no internet");
                }
            }
        }

       
      
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
        isDead = false;
        AudioManager.instance.musicSource.Play();
        AudioManager.PlayMusic("LevelOst");
        SceneManager.LoadScene("MenuScreen");
        try
        {
            HighScoreScript.startdata();
        }
        catch
        {
            Debug.Log("Player Not Loaded");
        }
       
        GlobalPoints.Instance.Reset();
        PointManager.points = GlobalPoints.Instance.getPoints();
        LoopCounter.Instance.Reset();
        PointManager.LoopPoints3 = LoopCounter.Instance.getPoints();
       
        TimeManager.Instance.Reset();
        
        //WinningScreen.SetActive(false);
        // MenuScreen.run = true;
    }

    public void QuitGame2()
    {

        AudioManager.instance.musicSource.Play();
        AudioManager.PlayMusic("LevelOst");
        SceneManager.LoadScene("MenuScreen");
        
        

        //WinningScreen.SetActive(false);
        // MenuScreen.run = true;
    }

    
    

}
