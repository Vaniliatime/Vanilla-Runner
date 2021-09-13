using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(CharacterController))]

public class PlayerController : MonoBehaviour
{
  
    public AudioSource audioSource;
    public Animator animator;

 

    [HideInInspector]
    public bool canMove = true;

    public GameObject waitScreen;
        public GameObject escMenu;


    public static bool GameIsPaused = true;
    public CharacterController controller;
    public Vector3 moveVector;
    public float speed = 40f;
    public float hSpeed = 25f;
    public float slower = 15f;




    




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



     







        if (Input.GetKey(KeyCode.LeftShift))
        {
            slowSpeed();
       

        }
        else
        {
            sprint();
        }






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
            Cursor.visible = true;
            

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


    void sprint ()
    {
        speed = 55f;
        

    }
    void slowSpeed()

    {
        speed = 15f;
      


    }

   
}