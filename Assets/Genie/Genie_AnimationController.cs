using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Genie_AnimationController : MonoBehaviour
{
    public GameObject Genie;
   
    private void OnTriggerEnter(Collider other)
    {
        Genie.GetComponent<Animator>().SetInteger("State", 1);
    }
}
