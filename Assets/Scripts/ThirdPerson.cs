using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPerson : MonoBehaviour
{

    private CharacterController controller;
    private Vector3 moveVector;
    public float speed = 20f;
    public float hSpeed = 25f;

 









    void Start()
    {
        controller = GetComponent<CharacterController>();
    }


    void Update()
    {
        moveVector = Vector3.zero;
        moveVector.x = Input.GetAxisRaw("Horizontal") * hSpeed;

        moveVector.z = speed;


        controller.Move(moveVector * Time.deltaTime);









    }


}

