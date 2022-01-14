using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


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
    public float speed;
    public float hSpeed;
    public float slower = 15f;
    public float maxspeed;
    public float maxhSpeed;




    




    Animator anim;
    void Start()
    {
        Application.targetFrameRate = 144;
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

        if(speed < maxspeed)
        speed += 0.3f * Time.deltaTime;
        

        if (hSpeed < maxhSpeed)
            hSpeed += 0.1f * Time.deltaTime;

        controller.Move(moveVector * Time.deltaTime);



        anim.SetFloat("RUN", speed);






        /* 
         * Shift SlowDown
         
        if (Input.GetKey(KeyCode.LeftShift))
        {
            slowSpeed();
       

        }
        else
        {
            sprint();
        }
      
    */




        if (Input.anyKeyDown)
        {
            if (GameIsPaused)
            {
                Resume();

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
        SceneManager.LoadScene("Menu");


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