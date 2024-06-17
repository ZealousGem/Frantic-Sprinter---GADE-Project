using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuScreen : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject levelSelectPanel;
   // public static bool run;
    //public GameObject howToPlayPanel;

    // Start is called before the first frame update
    void Start()
    {
        //run = true;
        levelSelectPanel.SetActive(false);
        startPanel.SetActive(true);
        AudioManager.instance.musicSource.Play();
        AudioManager.PlayMusic("LevelOst");
        //howToPlayPanel.SetActive(false);
    }

    public void PlayClick()
    {
        startPanel.SetActive(false);
        levelSelectPanel.SetActive(true);
        Debug.Log("work");
    }

    public void HowToPlayClick()
    {
      //  howToPlayPanel.SetActive(true);
        startPanel.SetActive(false);
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Main");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("MainLevel2");
        AudioManager.instance.musicSource.Stop();
        AudioManager.PlayMusic("Level2");


    }

     public void LoadLevel3()
     {
        SceneManager.LoadScene("MainLevel3");
        AudioManager.instance.musicSource.Stop();
        AudioManager.PlayMusic("Level2");

    }

    public void Back()
    {
        startPanel.SetActive(true);
        levelSelectPanel.SetActive(false);
        //howToPlayPanel.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }
}