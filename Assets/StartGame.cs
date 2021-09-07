using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject waitScreen;


    public static bool GameIsPaused = true;

    void Start()
    {
        Pause();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.P))
        {
            if (GameIsPaused)
            {
                Resume();

            }

        }
    }
   

    void Resume()
    {
        waitScreen.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        waitScreen.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
