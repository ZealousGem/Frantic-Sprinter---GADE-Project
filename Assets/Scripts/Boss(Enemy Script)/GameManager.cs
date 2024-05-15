using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject boss;
    public GameObject bossText;
    
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
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (TimeCounter.bridge == 70)
        {
            boss.SetActive (true);
            bossText.SetActive (true);
            texting = true;
        }
        


        if (goAway == true)
        {
            bossText.SetActive(false);
            //Debug.Log(GameOverMenu.bossy);

        }
        

        if (TimeCounter.bridge == 150)
        {
            EnemyMovement.DeathTime = true;
        }

        if (TimeCounter.bridge == 152)
        {
            enter = true;
        }
    }

   
}
