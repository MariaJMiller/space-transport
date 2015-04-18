// The JET model found in the Unity Store has to be rotated
// 270 degrees to face forward correctly. Using the jet's
// transform.forward does not shoot in the forward direction.


using UnityEngine;
using System.Collections;

public class BoltShot : MonoBehaviour {

	private float speed = 100;

	private Transform jetTransform;
	// Use this for initialization
	void Start () {
	
		jetTransform = GameObject.Find("Jet").transform;
		rigidbody.velocity = (-jetTransform.up * speed);
	}

}
