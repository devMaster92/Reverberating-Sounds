using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentChild : MonoBehaviour
{
    public Transform destination;
    public Transform collidingObject;
    private AudioSource sound;
    public GameObject parent;

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Socket") {
            sound = GetComponent<AudioSource>();
            sound.Play();
        }
        //collidingObject.transform.parent = destination;
        collidingObject.transform.SetPositionAndRotation(destination.transform.GetChild(3).gameObject.transform.position, destination.transform.GetChild(3).gameObject.transform.rotation);
        //collidingObject.transform.SetPositionAndRotation(destination.transform.position, destination.transform.rotation);
        //other.transform.SetPositionAndRotation(gameObject.transform.position, gameObject.transform.rotation);
        //other.transform.SetParent(gameObject.transform);
    }
}
