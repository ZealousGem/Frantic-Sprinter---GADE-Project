using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector3 endPos = new Vector3 (0f, 0f, 0f);
    float speed = 100;

    // Update is called once per frame
    private void Start()
    {
        AudioManager.instance.SFX("Missile");
    }
    void Update()
    {
        if (transform.position != endPos)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPos, speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("destroy"))
        {
            Destroy(other.gameObject);
        }
    }
}
