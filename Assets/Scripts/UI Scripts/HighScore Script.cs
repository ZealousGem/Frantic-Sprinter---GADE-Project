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
    public static int num2 = 0;
    public static int num3 = 0;
    public Text socre;
    public Text loop;
    public Text Time;
    public GameObject main;
     void  Start()
    {
       highscore.SetActive(false);
      


    }

   public static async void startdata()
    {
        try
        {
            Item data = await CloudSave.LoadData();

            num = data.Value.GetAs<int>();
        }

        catch
        {
            num = 0;
        }
        try
        {
            Item data2 = await CloudSave.LoadLoops();

            num2 = data2.Value.GetAs<int>();
        }

        catch
        {
            num2 = 0;
        }

        try
        {
            Item data3 = await CloudSave.LoadTime();

            num3 = data3.Value.GetAs<int>();
        }

        catch { num3 = 0; }
       ;
    }

    

    // Update is called once per frame
    public async void ButtonClick()
    {
        main.SetActive(false);
        highscore.SetActive(true);
        try
        {
           
            Item data = await CloudSave.LoadData();
            Debug.Log(data.ToString());
            Debug.Log(GameOverMenu.saveScore.ToString());
            // num = data.Value.GetAs<int>();
            socre.text = data.Value.GetAs<int>().ToString();
            print(socre);

            

            Item data3 = await CloudSave.LoadTime();
            Time.text = data3.Value.GetAs<int>().ToString();
            print(Time);

        }
        
        catch
        {
            socre.text = num.ToString();
           
           

        }

        try {
            Item data2 = await CloudSave.LoadLoops();
            loop.text = data2.Value.GetAs<int>().ToString();
            print(loop);
        }
        catch {

            loop.text = num2.ToString();

        }

        try
        {
            Item data3 = await CloudSave.LoadTime();
            Time.text = data3.Value.GetAs<int>().ToString();
            print(Time);
        }

        catch
        {
            Time.text = num3.ToString();
        }
    }

    public void back()
    {
        main.SetActive(true);
        highscore?.SetActive(false);
    }
}
