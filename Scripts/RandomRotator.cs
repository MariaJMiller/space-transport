using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour {

	private float tumble = 5;

	// Use this for initialization
	void Start () {
		rigidbody.angularVelocity = Random.insideUnitSphere * tumble;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
