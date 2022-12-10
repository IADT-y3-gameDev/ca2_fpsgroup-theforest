using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateProjectile : MonoBehaviour
{

    public GameObject projectile;
    public ParticleSystem muzzleFlash;
    public GameObject clone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            muzzleFlash.Play();
            clone = Instantiate(projectile, gameObject.transform.position, gameObject.transform.rotation);

            Destroy(clone,2.0f);
        }
        
    }
}

