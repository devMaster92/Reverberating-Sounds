using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCollider : MonoBehaviour
{
    public ParticleSystem Effect;
    private AudioSource SoundEffect;

    void Start()
    {
        SoundEffect = GetComponent<AudioSource>();    
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Stones" || other.tag == "Bullet" || other.tag == "Cannon")
        {
            SoundEffect.Play();
            Effect.Play();
        }

       
    }
}
