using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engine_Sound : MonoBehaviour
{
    public float minspeed;
    public float maxspeed;
    private float currentspeed;

    private Rigidbody carRb;
    private AudioSource caraudio;   

    public float minpitch;
    public float maxpitch;
    private float pitchfromcar;
   
    void Start()
    {
        caraudio = GetComponent<AudioSource>();
        carRb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        EngineSound();
    }
    void EngineSound()
    {
        currentspeed = carRb.velocity.magnitude;
        pitchfromcar = carRb.velocity.magnitude / 50f;

        if (currentspeed < minspeed)
        {
            caraudio.pitch = minpitch;
        }
        if(currentspeed > minspeed && currentspeed < maxspeed)
        {
            caraudio.pitch = minpitch + pitchfromcar;
        }
        if(currentspeed > maxspeed)
        {
            caraudio.pitch = maxpitch;
        }
    }
}
