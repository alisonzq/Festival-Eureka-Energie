using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour {

    public GameObject destination;

	void OnTriggerEnter(Collider col)
    {

        if (col.CompareTag("Player"))
        {
            col.transform.position = destination.transform.position;
            
        }
    }

}