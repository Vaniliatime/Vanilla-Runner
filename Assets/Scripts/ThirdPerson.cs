using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPerson : MonoBehaviour
{
    


    public float speed = 20f;











    void Start()
    {

    }


    void Update()
    {


        float hMovement = Input.GetAxis("Horizontal") * speed;
        float vMovement = Input.GetAxis("Vertical") * speed;

        transform.Translate(new Vector3(hMovement, 0, vMovement) * Time.deltaTime);









    }


}

