using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour
{
	// Start is called before the first frame update
	public Transform newParent;
	public float dist= 2.5f;
	public Transform player;
    void Update() {
		if (dist >= Vector3.Distance(gameObject.transform.position, player.position)) {
			Debug.Log(dist);
			transform.parent = newParent;
		}
	}
}
