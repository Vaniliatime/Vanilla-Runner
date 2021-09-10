using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public ParticleSystem coinParticles;

    public float turnSpeed = 90f;


    private void OnTriggerEnter(Collider other)
    {



        if (other.gameObject.name != "Player")
        {
            return;
        }


        gameManager.inst.IncrementScore();




        Instantiate(coinParticles, transform.position, Quaternion.identity);

        Destroy(gameObject);
    }


   

    void Start()
    {
        
    }


    void Update()
    {
        transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
    }


}
