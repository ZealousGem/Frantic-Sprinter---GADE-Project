using System.Collections;
using UnityEngine;

public class BossSpawner : MonoBehaviour
{
    [SerializeField] private GameObject spawner;
    [SerializeField] private float minFrequency = 1f; // Minimum time between spawns
    [SerializeField] private float maxFrequency = 10f; // Maximum time between spawns
    [SerializeField] private float intSpeed = 1f; // Speed of the spawned boss (if needed)

    private float timeSinceLastSpawn = 0f;
    private float nextSpawnTime;

    void Start()
    {
        SetNextSpawnTime();
    }

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= nextSpawnTime)
        {
            GameManager.goAway = true;
            StartCoroutine(pickingABoss());
            SetNextSpawnTime();
            timeSinceLastSpawn = 0f; // Reset the timer
        }
    }

    void SetNextSpawnTime()
    {
        nextSpawnTime = Random.Range(minFrequency, maxFrequency);
    }

    public IEnumerator pickingABoss()
    {
        Spawn(spawner);
        yield return new WaitForSeconds(5f); // Wait for 5 minutes before potentially spawning again
    }

    public void Spawn(GameObject boss)
    {
        GameObject newSpawn = Instantiate(boss, transform.position, Quaternion.identity);
        newSpawn.transform.parent = transform;
    }
}