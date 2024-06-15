using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject spawner1;
    [SerializeField] private GameObject spawner2;
    [SerializeField] private GameObject spawner3;
    [SerializeField] private GameObject ActualSpawn;
    [SerializeField] private float frequency;
    [SerializeField] private float intSpeed;
    [SerializeField] List<GameObject> SpawenrRand;
    private float lastSpawn;
    

    private void Start()
    {
        SpawenrRand.Add(spawner1);
        SpawenrRand.Add(spawner2);
        SpawenrRand.Add(spawner3);
       
    }
   

    // Update is called once per frame
    void Update()
    {
       
        if (Time.time > lastSpawn + frequency)
        {
            int i = Random.Range(0, SpawenrRand.Count);
            ActualSpawn = SpawenrRand[i];
            if (ActualSpawn != null)
            {
                Spawn();
                lastSpawn = Time.time;
            }
           
            
        }
    }

    public void Spawn()
    {

        GameObject newSpawn = Instantiate(ActualSpawn, transform.position, Quaternion.identity);
        // newSpawn.transform.position += transform.forward * intSpeed * Time.deltaTime; 
        newSpawn.transform.parent = transform;
    }
}

/*Kory Code. (2022). “How to Spawn and Destroy Objects in Unity: The Complete Guide”. Available at:
 * https://www.youtube.com/watch?v=zxqQ_Uwt-eU [Last Accessed 2 April 2024]
*/

