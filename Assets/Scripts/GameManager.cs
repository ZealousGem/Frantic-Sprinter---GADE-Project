using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject boss;
    void Start()
    {
        boss.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (TimeCounter.bridge == 80)
        {
            boss.SetActive (true);
        }

        if (TimeCounter.bridge == 150)
        {
            EnemyMovement.DeathTime = true;
        }
    }

   
}
