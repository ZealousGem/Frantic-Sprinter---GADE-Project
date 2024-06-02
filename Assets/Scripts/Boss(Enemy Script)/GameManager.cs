using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject boss;
    public GameObject looper;
    public GameObject bossText;
   // string[] scenes = { "MainLevel2", "MainLevel3" }; 
    public static bool goAway;
    public static bool enter;
    public static bool texting;
   
    void Start()
    {
        goAway = false;
        texting = false;
        Level1Manager.goaway2 = false;
        enter = false;
        boss.SetActive(false);
        bossText.SetActive(false);
        looper.SetActive(false);

        //  Debug.Log(currentScene);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (TimeCounter.bridge == 70)
        {
            boss.SetActive(true);
            bossText.SetActive(true);
            texting = true;
            
        }



        if (goAway == true)
        {
            bossText.SetActive(false);
            //Debug.Log(GameOverMenu.bossy);

        }


        if (TimeCounter.bridge == 150)
        {
            Destroy(boss);
        }

        if (TimeCounter.bridge == 152)
        {

            looper.SetActive(true);
        }



    }

  





}