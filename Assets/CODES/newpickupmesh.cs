using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newpickupmesh : MonoBehaviour
{

    public Transform theDest;

    void OnMouseDown()
    {
        GetComponent<MeshCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = theDest.position;
        this.transform.parent = GameObject.Find("Destination").transform;
    }



    void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<MeshCollider>().enabled = true;



    }
}