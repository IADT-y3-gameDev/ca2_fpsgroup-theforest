using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
     Animator doorAnim;

    void Start() {
        doorAnim = gameObject.GetComponent<Animator>();
     }
    void OnCollisionEnter(Collision other)
    {
        doorAnim.SetTrigger("OpenDoor");
        Debug.Log("Door Opening");
    }
}
