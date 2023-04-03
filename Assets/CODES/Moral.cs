using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moral : MonoBehaviour
{
    public GameObject moral;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other) {
        moral.SetActive(true);
        
        
    }


}
