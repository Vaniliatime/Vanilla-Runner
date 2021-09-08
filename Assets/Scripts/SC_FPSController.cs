using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class SC_FPSController : MonoBehaviour
{
  
    private AudioSource audioSource;
    public Animator animator;

 

    [HideInInspector]
    public bool canMove = true;

    public GameObject waitScreen;
        public GameObject escMenu;


    public static bool GameIsPaused = true;
    private CharacterController controller;
    private Vector3 moveVector;
    public float speed = 20f;
    public float hSpeed = 25f;



    Animator anim;
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        anim = gameObject.GetComponent<Animator>();


        controller = GetComponent<CharacterController>();



        // Lock cursor

        Cursor.visible = false;

        Pause();

    }

    void Update()
    {
     

        // Move the controller
        moveVector = Vector3.zero;
        moveVector.x = Input.GetAxisRaw("Horizontal") * hSpeed;

        moveVector.z = speed;


        controller.Move(moveVector * Time.deltaTime);



        if (Input.GetKeyDown(KeyCode.P))
        {
            if (GameIsPaused)
            {
                Resume();

            }
            else
            {
                Pause();
            }
           

        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenu();
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

    void PauseMenu()
    {
        escMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    void ResumeMenu()
    {
        escMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }


    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.transform.tag =="Obstacle")
        {
            PlayerManager.gameOver = true;
        }
    }

}