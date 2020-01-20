using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_tree : MonoBehaviour
{
	private AudioSource TreeCollision;  //Add you Audio Clip here;
                                // This Will Configure the  AudioSource Component; 
    // Start is called before the first frame update
    void Start()
    {
        TreeCollision = GetComponent<AudioSource>();    
	}

	private void OnTriggerEnter(Collider other)  //Plays Sound Whenever collision detected
	{
        if (other.tag == "Player") {
            TreeCollision.Play();
        }
	}
}
