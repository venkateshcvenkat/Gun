using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistoal : MonoBehaviour
{
    public float damage = 10f;
    public float range = 500f;
    public Camera fpscamera;
    public AudioSource audiosource;
    public AudioClip[] Bulletsound;
    public ParticleSystem particle;
   

    void Start()
    {
        
    }


    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
          
        }
        
    }
    void Shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(fpscamera.transform.position, fpscamera.transform.forward, out hit, range))
        {
           if (hit.transform.CompareTag("cube"))
           {
                 hit.transform.gameObject.GetComponent<Damage>().TakeDamage(damage);
           }
        }
        audiosource.clip = Bulletsound[Random.Range(0, Bulletsound.Length)];
        audiosource.Play();
        particle.Play();
       
    }
}
