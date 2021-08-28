using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPerson : MonoBehaviour
{
    Animator anim;

    public Animator animator;

    public CharacterController controller;
    public Transform cam;

    public float speed = 2f;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;


    public float speedboost = 6f;

    public float gravity = 15f;
    public float jumpForce = 10f;

    public float verticalVelocity;

 

   


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        anim = GetComponent<Animator>();
       
    }


    void Update()
    {
       

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = 1;
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

   





        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;

            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }



        /* Sprint */

        if (Input.GetKeyDown(KeyCode.LeftShift))
            speed += speedboost;
        else if (Input.GetKeyUp(KeyCode.LeftShift))
            speed -= speedboost;


        /* Jump / Ground Check */


        if (controller.isGrounded)
        {
            verticalVelocity = -gravity * Time.deltaTime;
            if (Input.GetKey(KeyCode.Space))
            {
                verticalVelocity = jumpForce;
            }
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }

            Vector3 moveVector = Vector3.zero;
            moveVector.x = Input.GetAxis("Horizontal") * 5.0f;
            moveVector.y = verticalVelocity;
            moveVector.z = Input.GetAxis("Vertical") * 5.0f;
            controller.Move(moveVector * Time.deltaTime);
        }




    }




