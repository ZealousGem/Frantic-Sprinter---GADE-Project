using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingGun : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject spawner;
    [SerializeField] private Transform moving;
    [SerializeField] private float frequency;
    [SerializeField] private float intSpeed;


    private float lastSpawn;
    /*void Start()
    {
        
    } */

    // Update is called once per frame
    private void Start()
    {
        spawner.SetActive(false);
    }
    void Update()
    {
        if (WeaponEffect.activateGun is true)
        {
            spawner.SetActive (true);
            if (Time.time > lastSpawn + frequency)
            {
                Spawn();
                lastSpawn = Time.time;

            }

        }

        spawner.SetActive(false);

    }

    public void Spawn()
    {

        GameObject newSpawn = Instantiate(spawner, transform.position, Quaternion.identity);
        newSpawn.GetComponent<Rigidbody>().velocity = moving.forward * intSpeed;
         //newSpawn.transform.position += transform.forward * intSpeed * Time.deltaTime; 
        newSpawn.transform.parent = transform;
    }
}
