using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static int points { get; set; }
    public Text Points;
    public Text Display;

    //int finalPoints = 0;
    void Start()
    {
        //  finalPoints = 0;

        

       
        
          points = GlobalPoints.Instance.getPoints();
        
      
    }

    // Update is called once per frame
    void Update()
    {
        
        Points.text = points.ToString();
        Display.text = Points.text;
        GlobalPoints.Instance.setPointsint(points); 
       // Debug.Log(points);
    }
}
