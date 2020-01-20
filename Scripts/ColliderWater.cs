using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderWater : MonoBehaviour
{
    //private AudioSource[] WaterCollision;
    public AudioClip FishAudioClip;
    public AudioClip BlobAudioClip;
    public AudioClip WhaleAudioClip;
    AudioSource FishAudioSource;
    AudioSource BlobAudioSource;
    AudioSource WhaleAudioSource;
    public ParticleSystem splashEffect;                                    
                                                                     
    void Start()
    {
        //WaterCollision = GetComponents<AudioSource>();

        FishAudioSource = GetComponent<AudioSource>();
        BlobAudioSource = GetComponent<AudioSource>();
        WhaleAudioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)  //Plays Sound Whenever collision detected
    {
        if (other.tag == "Fish")
        {
            FishAudioSource.clip = FishAudioClip;
            FishAudioSource.Play();
        }
        else if (other.tag == "Blob")
        {
            BlobAudioSource.clip = BlobAudioClip;
            BlobAudioSource.Play();
        }
        else if (other.tag == "Whale")
        {
            WhaleAudioSource.clip = WhaleAudioClip;
            WhaleAudioSource.Play();
        }
        //WaterCollision.Play();
        splashEffect.transform.position = other.transform.position;
        splashEffect.Play();

    }
}
