using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class EnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update

  [NonSerialized] public  float mveSpeed = 5f;
    // Rigidbody rb;
    // Vector3 movement;
   // public GameObject boss;
    public GameObject gun;
    
    public Vector3 startpos = new Vector3(0f, 0f, 0f);
    public Vector3 endpos1 = new Vector3(0f, 0f, 0f);
    public Vector3 endpos2 = new Vector3(0f, 0f, 0f);
    public Animator mve;
    string boss = "Boss";
    int bossHealth = 200;
  [NonSerialized]  public static bool DeathTime;
    bool begin = false;
    bool right;
    bool left;

    void Start()
    {
       
            left = true;
            right = false;
            DeathTime = false;
            gun.SetActive(false);
        mve.SetBool(boss, true);
           
         
          
    }



   
    private void Update()
    {
       
            if (begin != false)
            {
            if (DeathTime != true)
            {
               
                gun.SetActive(true);
                if (right is true)
                {
                    MoveLeft();
                }

                if (left is true)
                {
                    MoveRight();
                }
            }

            else
            {
                Death();
            }
                
            }

            else
            {
                introMovement();
            }
        
       
    }

   

    // Update is called once per frame
    
   

    public void MoveLeft()
    {
        // rb.MovePosition(movement, endpos1 * mveSpeed);
        if (transform.position != endpos1)
        {
            transform.position = Vector3.MoveTowards(transform.position, endpos1, mveSpeed * Time.deltaTime);
        }

        else
        {
            left = true;
            right = false;
        }
    }

    public void MoveRight()
    {
        // rb.MovePosition(movement * mveSpeed);
        if (transform.position != endpos2)
        {
            transform.position = Vector3.MoveTowards(transform.position, endpos2, mveSpeed * Time.deltaTime);
        }

        else
        {
            right = true;
            left = false;
        }
    }

    public void introMovement()
    {
       
        if (transform.position != startpos)
        {
           
            transform.position = Vector3.MoveTowards(transform.position, startpos, mveSpeed * Time.deltaTime);
        }

        else
        {
            begin = true;
            GameManager.goAway = true;
            mve.SetBool(boss, false);
       
            
        }
    }

    public void Death()
    {
        Destroy(this.gameObject);    
    }

    public void LoseHealth()
    {
        bossHealth -= 10;
    }

    

}
