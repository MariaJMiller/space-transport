// The JET model found in the Unity Store has to be rotated
// 270 degrees to face forward correctly. Using 
// transform.forward does not shoot in the forward direction.


using UnityEngine;
using System.Collections;

public class BoltShot : MonoBehaviour {

	private Transform jet;

	private float speed = 150;
	
	// Use this for initialization
	void Start () {
	
		jet = GameObject.Find ("Jet").transform;
		rigidbody.velocity = (-jet.up * speed);
	}

}
