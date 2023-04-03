using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{

    public GameObject door;
    public GameObject door1;

    void OnCollisionEnter(Collision other)
    {
        
        door.SetActive (false);
        door1.SetActive (false);
        
    }

}
