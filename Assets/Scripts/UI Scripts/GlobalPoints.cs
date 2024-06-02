using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalPoints : MonoBehaviour
{
    // Start is called before the first frame update
    public static GlobalPoints Instance { get; private set; }
    public int points { get; private set; }
void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else { Destroy(gameObject); }
    }
    private void Start()
    {
            points = 0;
    }
    // Update is called once per frame
    public void setPointsint(int newPoints)
    {
        points = newPoints;
    }

    public int getPoints()
    {
        return points;
    }

    public void Reset()
    {
        points = 0;
    }
}
