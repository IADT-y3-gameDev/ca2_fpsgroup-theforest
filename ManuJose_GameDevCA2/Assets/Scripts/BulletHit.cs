using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHit : MonoBehaviour
{

    public ParticleSystem HitEffect;
 
    void OnCollisionEnter(Collision other){
        ContactPoint contact = other.contacts[0];
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;
        Instantiate(HitEffect, pos, rot);
        HitEffect.Play();
        gameObject.SetActive(false);
    }
}
