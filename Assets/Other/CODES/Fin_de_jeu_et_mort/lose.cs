﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lose : MonoBehaviour
{

    void OnTriggerEnter()

    {
        GameManager.instance.lose();

    }
}