using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectGem : MonoBehaviour
{

void OnTriggerEnter(Collider other)
{
    Achivements.Ach01Count += 1;

    Achivements.Ach02Count += 1;

    Achivements.Ach03Count += 1;

    Achivements.Ach04Count += 1;

    Achivements.Ach05Count += 1;


}



}

