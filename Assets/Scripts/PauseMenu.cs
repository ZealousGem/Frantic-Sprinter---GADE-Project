using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pause;
    public GameOverMenu gameOver;
    public static bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        pause.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver.isActive is true)
        {
            pause.SetActive(false);
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (isPaused)
                {
                    resumeGame();
                }

                else
                {
                    pasueGame();
                }
            }
        }
    }

    public void pasueGame()
    {
        pause.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void resumeGame()
    {
        pause.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void restartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main");
    }
}

/*
 BMo.(2020). “6 Minute Pause Menu Unity Tutorial”. Available at:
https://www.youtube.com/watch?v=9dYDBomQpBQ [Last Accessed 2 April 2024]

 
 */
