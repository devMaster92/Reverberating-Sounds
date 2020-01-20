﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEmitter : MonoBehaviour
{
    //Drag in the Bullet Emitter from the Component Inspector.
    public GameObject Bullet_Emitter;

    //Drag in the Bullet Prefab from the Component Inspector.
    public GameObject Bullet;
    //public ParticleSystem GunEffect;
    public AudioClip GunAudioClip;
    AudioSource GunAudioSource;

    //Enter the Speed of the Bullet from the Component Inspector.
    public float Bullet_Forward_Force;

    private void Start()
    {
        GunAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            //The Bullet instantiation happens here.
            GameObject Temporary_Bullet_Handler;
            Temporary_Bullet_Handler = Instantiate(Bullet, Bullet_Emitter.transform.position, Bullet_Emitter.transform.rotation) as GameObject;

            //Sometimes bullets may appear rotated incorrectly due to the way its pivot was set from the original modeling package.
            //This is EASILY corrected here, you might have to rotate it from a different axis and or angle based on your particular mesh.
            Temporary_Bullet_Handler.transform.Rotate(Vector3.left * 90);

            //Retrieve the Rigidbody component from the instantiated Bullet and control it.
            Rigidbody Temporary_RigidBody;
            Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();

            

            GunAudioSource.clip = GunAudioClip;
            GunAudioSource.Play();
            //GunEffect.Play();
            //Tell the bullet to be "pushed" forward by an amount set by Bullet_Forward_Force. 
            Temporary_RigidBody.AddForce((transform.forward * -1) * Bullet_Forward_Force);

            //Basic Clean Up, set the Bullets to self destruct after 10 Seconds, I am being VERY generous here, normally 3 seconds is plenty.
            Destroy(Temporary_Bullet_Handler, 10.0f);
        }
    }
}
