using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Manager : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    public static bool goaway2;

    private void Start()
    {
        goaway2 = false;
        GameManager.enter = false;
    }
    void FixedUpdate()
    {
        if (TimeCounter.bridge == 60)
        {
            goaway2 = true;
        }
    }
}
