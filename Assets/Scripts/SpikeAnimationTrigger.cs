using System.Collections.Generic;
using UnityEngine;

public class SpikeAnimationTrigger : MonoBehaviour
{

    bool KeyPressed;
    public GameObject Spears;


    public GameObject Spear1;
    public GameObject Spear2;
    public GameObject Spear3;
    public GameObject Spear4;
    public GameObject Spear5;
    public GameObject Spear6;
    public GameObject Spear7;
    public GameObject Spear8;
    public GameObject Spear9;
    public Animator animator;

    public List<GameObject> AllSpears;

    void Start()
    {
        Animator animator = GetComponent<Animator>();
        AllSpears = new List<GameObject>();
        AllSpears.Add(Spear1);
        AllSpears.Add(Spear2);
        AllSpears.Add(Spear3);
        AllSpears.Add(Spear4);
        AllSpears.Add(Spear5);
        AllSpears.Add(Spear6);
        AllSpears.Add(Spear7);
        AllSpears.Add(Spear8);
        AllSpears.Add(Spear9);
    }


    void Update()
    {
        TriggerAnimation();
    }

    void TriggerAnimation()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            KeyPressed = true;
            animator.SetBool("KeyPressed", true);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            KeyPressed = false;
            animator.SetBool("KeyPressed", false);
        }
    }
}
