using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateClown : MonoBehaviour
{
    public GameObject ObjectToTurnOn;
    public GameObject ObjectToTurnOn2;

    void OnCollisionEnter(Collision other)
    {
        
        ObjectToTurnOn.SetActive (true);
        gameObject.SetActive(false);
        if(ObjectToTurnOn2 != null){
            ObjectToTurnOn2.SetActive (true);

        }
    }
}
