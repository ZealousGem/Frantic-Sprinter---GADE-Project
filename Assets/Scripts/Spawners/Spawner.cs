using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update

     [SerializeField]private GameObject spawner;
     [SerializeField]private float frequency;
     [SerializeField] private float intSpeed;
   

    private float lastSpawn; 
    void Start()
    {
      
    } 

    // Update is called once per frame
    void Update()
    {
     
        if(Time.time > lastSpawn + frequency)
        {
            Spawn();
            lastSpawn = Time.time;

        }
    }

    public void Spawn()
    {
        
        GameObject newSpawn = Instantiate(spawner, transform.position, Quaternion.identity);
       // newSpawn.transform.position += transform.forward * intSpeed * Time.deltaTime; 
        newSpawn.transform.parent = transform;
    }
}

/*Kory Code. (2022). “How to Spawn and Destroy Objects in Unity: The Complete Guide”. Available at:
 * https://www.youtube.com/watch?v=zxqQ_Uwt-eU [Last Accessed 2 April 2024]
*/