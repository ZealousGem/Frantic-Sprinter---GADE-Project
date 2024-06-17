using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float Speed = 5f;
    [SerializeField] private float jump = 5f;
    private bool isGrounded;

    private Rigidbody rb;
    private Vector3 JumpInput;
    public int score = 100;
    public score health;
    public GameOverMenu gameOverMenu;
    public Animator Ani;
    private int newScore = 0;
    private int damage = 50;
    private int heal = 25;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        newScore = score;
        gameOverMenu.score = newScore;
        JumpInput = new Vector3(0f, 0.0f, 0f);
    }

    void Damage(int damage)
    {
        newScore -= damage;
        gameOverMenu.score = newScore;
        health.updateHealth(newScore);
        //  gameOverMenu.Number(newScore);
    }

    void Heal(int heal)
    {
        newScore += heal;
        gameOverMenu.score = newScore;
        health.updateHealth(newScore);
    }



    // Update is called once per framelll
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;

        }


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("destroy"))
        {
            switch (gameObject.tag)
            {
                case "Player": Damage(damage); break;
                case "Destroyer": Destroy(other.gameObject); PointManager.points += 10; AudioManager.instance.SFX("Points"); break;
            }
             
        }

        if (other.gameObject.CompareTag("Boss"))
        {
            switch (gameObject.tag)
            {
                case "Player": Damage(damage); break;
                case "Destroyer": Destroy(other.gameObject); PointManager.points += 10; AudioManager.instance.SFX("Points"); break;
            }
        }

        if (other.gameObject.CompareTag("Boss2"))
        {
             switch (gameObject.tag)
            {
                case "Player": Damage(damage); break;
                case "Destroyer": Destroy(other.gameObject); PointManager.points += 10; AudioManager.instance.SFX("Points"); break;
            }
        }




        if (other.gameObject.CompareTag("PickUp"))
        {
            Destroy(other.gameObject);
            AudioManager.instance.SFX("PowerUpPickup");
            Heal(heal);
            //Debug.Log("Item Picked Up");
        }
    }

    void Update()
    {

        //  Vector3  JumpInput = new Vector3(0f, 0f, 0f);
        Vector3 SpeedInput = new Vector3(0f, 0f, 0f);


        if (Input.GetKey(KeyCode.A))
        {
            SpeedInput.x = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            SpeedInput.x = +1;
        }

        if (Input.GetKey(KeyCode.Space) && isGrounded == true)
        {
            //rb.AddForce(JumpInput * jump, ForceMode.Impulse);
            rb.AddForce(new Vector3(rb.velocity.x, jump, 0f), ForceMode.Impulse);
            Ani.SetTrigger("Jump");
            AudioManager.instance.SFX("JumpEffect");
            isGrounded = false;

        }


        SpeedInput = SpeedInput.normalized;
        JumpInput = JumpInput.normalized;
        transform.position += SpeedInput * Speed * Time.deltaTime;
        transform.position += jump * JumpInput * Time.deltaTime;
        // Debug.Log(Time.deltaTime);
    }

}
/*
 Bblakeyy. (2019). “How To Have Only One Jump At A Time-Unity Tutorial”. Available at:
https://www.youtube.com/watch?v=ctpExP8GaiQ [Last Accessed 2 April 2024]*/