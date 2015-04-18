﻿using UnityEngine;
using System.Collections;

public class AsteroidMover : MonoBehaviour {
	
	private Transform jet;
	
	private float speed = 70;
	
	// Use this for initialization
	void Start () {
		
		jet = GameObject.Find ("Jet").transform;
		// Because the Jet Model is incorrectly rotated on import,
		// shooting in the z-axis is transform.up, not transform.forward
		rigidbody.velocity = (jet.up * speed);
	}

}
