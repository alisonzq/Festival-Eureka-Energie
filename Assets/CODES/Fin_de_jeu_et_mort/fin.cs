using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fin : MonoBehaviour
{

    void OnTriggerEnter()

    {
        GameManager.instance.Win();

    }
}