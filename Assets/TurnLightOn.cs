using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLightOn : MonoBehaviour
{
    public GameObject spotlight;
    private Animator animator;
    private int numPushed;
    public GameObject checkAnim;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnMouseUpAsButton()
    {
        Animator eolienneAnimator = checkAnim.GetComponent<Animator>();
        if (eolienneAnimator.GetCurrentAnimatorStateInfo(0).IsName("eolienne"))
        {
            Debug.Log("There is electricity!");
            numPushed++;
            //Debug.Log(numPushed);
            if (numPushed % 2 != 0)
            {
                //Écrit le code en dessous de cette ligne / Write code down below
                animator.SetTrigger("pushed"); //soit ca
                spotlight.SetActive(true); //ou ca
            }
            else
            {
                animator.SetTrigger("pushed");
                spotlight.SetActive(false);
            }
        }
        else
        {
            Debug.Log("no electricity!");
        }

    }
}
