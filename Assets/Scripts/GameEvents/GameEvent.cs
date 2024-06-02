using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEvent : MonoBehaviour
{
    // Start is called before the first frame update
    public static event Action IncreaseMovementSpeed;
    public static event Action BossSpawn;
    public static event Action PickUpSpawn;
    public static event Action BossDeath;
    public static event Action<string> LoadScene;

   
    public static void TiggerMoreSpeed()
    {
        if (IncreaseMovementSpeed != null)
        {
            IncreaseMovementSpeed.Invoke();
        }
    }

    public static void TriggerBossSpawn()
    {
        if (BossSpawn != null)
        {
            BossSpawn?.Invoke();
        }
         
        
    }

    public static void TriggerBossDeath()
    {
        
            BossDeath.Invoke();
        
    }

    public static void TriggerPickUp()
    {
        PickUpSpawn.Invoke();
    }

    public static void TriggerLoadScene(string scene) {

        if (LoadScene != null)
        {
            LoadScene?.Invoke(scene);
        }
    
    }
}
// https://www.youtube.com/watch?v=gx0Lt4tCDE0