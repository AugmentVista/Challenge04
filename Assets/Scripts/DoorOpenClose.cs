using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenClose : MonoBehaviour
{
    public GameObject chest;
    public Animator animator;

    private void OnTriggerStay(Collider other)
    {
        animator.SetBool("Closed", false);
        animator.SetBool("Open", true);
    }
    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("Closed", true);
        animator.SetBool("Open", false);
    }
}