using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
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

    public PickUpManager PickUpManager;
    public PointManager pointManager;


    public UnityEvent BossSpawn;
    public UnityEvent LooperSpawn;
    public UnityEvent BossDeath;
    public UnityEvent DisapperText;
  
    void Start()
    {
        goAway = false;
        texting = false;
        Level1Manager.goaway2 = false;
        enter = false;
        boss.SetActive(false);
        bossText.SetActive(false);
        looper.SetActive(false);


        PickUpManager.Pickup1.AddListener(PickUpManager.InvPickUp);
        PickUpManager.PlayerPickup2.AddListener(PickUpManager.GunPickUp);
        PickUpManager.StopPickups.AddListener(PickUpManager.Stop);

        pointManager.PointEvent.AddListener(pointManager.PointDisplay);

      

        //  Debug.Log(currentScene);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (TimeCounter.bridge == 60)
        {
          
           BossSpawn?.Invoke();
            
        }



        if (goAway == true)
        {
            DisapperText?.Invoke();
            //Debug.Log(GameOverMenu.bossy);

        }


        if (TimeCounter.bridge == 120)
        {
            BossDeath?.Invoke();
        }

        if (TimeCounter.bridge == 121)
        {

           LooperSpawn?.Invoke();
            
        }



    }

    public void Spawn()
    {
        boss.SetActive(true);
        bossText.SetActive(true);
        texting = true;
     
    }

    public void Death()
    {
        Destroy(boss);
        
    }

    public void Loop()
    {
        looper.SetActive(true);
    }

    public void BeGone()
    {
        bossText.SetActive(false);
    }

    
   




}