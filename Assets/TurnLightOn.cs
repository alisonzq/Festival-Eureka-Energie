using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLightOn : MonoBehaviour
{
  public GameObject light;

  void OnTriggerEnter (Collider target) 
  {
    if( target.gameObject.tag.Equals("turnOn") == true )
    {
      //Écrit le code en dessous de cette ligne / Write code below this line
        light.SetActive(true);
    }
  }

}
