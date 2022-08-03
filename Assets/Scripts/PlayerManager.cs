using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
   
    public static bool gameOver;
    public GameObject gameOverPanel;

    public Animator animator;

    public PlayerController playercontrollscript;

    void Start()
    {
        gameOver = false;
        Time.timeScale = 1;

        Animator animator = gameObject.GetComponent<Animator>();

        
    }


    
    

    // Update is called once per frame
    
    void Update()
    {
        if (gameOver)
        {
          
            gameOverPanel.SetActive(true);
            Cursor.visible = true;

            animator.SetTrigger("deatht");

            playercontrollscript.speed = 0f;
            playercontrollscript.hSpeed = 0f;

            Achivements.Ach06Count += 1;
        
        }

    }

  
}

