using System.Collections;
using System.Collections.Generic;
using Unity.Services.CloudSave.Models;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject highscore;
    public static int num = 0;
    public Text socre;
    public GameObject main;
     void  Start()
    {
       highscore.SetActive(false);
      


    }

   public static async void startdata()
    {
        Item data = await CloudSave.LoadData();
       
            num = data.Value.GetAs<int>();
        
    }

    public async void setLoop()
    {

        Item data = await CloudSave.LoadData();
    }

    // Update is called once per frame
    public async void ButtonClick()
    {
        try
        {
            main.SetActive(false);
            highscore.SetActive(true);
            Item data = await CloudSave.LoadData();
            Debug.Log(data.ToString());
            Debug.Log(GameOverMenu.saveScore.ToString());
            // num = data.Value.GetAs<int>();
            socre.text = data.Value.GetAs<int>().ToString();
            print(socre);
        }
        
        catch
        {
            socre.text = num.ToString();
        }
    }

    public void back()
    {
        main.SetActive(true);
        highscore?.SetActive(false);
    }
}
