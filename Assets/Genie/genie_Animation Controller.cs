using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class genie_AnimationController : MonoBehaviour
{
    public GameObject Genie;
    Animator Anim;

    // Start is called before the first frame update
    void Start()
    {
        Anim = Genie.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        print("TriggerEnter " + other.name);
        if (other.name == "FPSController")
        {
            Anim.SetInteger("DoorStatus", 1);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        print("TriggerExit " + other.name);
        if (other.name == "FPSController")
        {
            Anim.SetInteger("DoorStatus", 2);
        }
    }

}
