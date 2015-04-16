using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private float speed = 20;

	private Vector3 moveForward = new Vector3(0, 0, 2);

	private Rigidbody jetRB;

	void Start () {

		jetRB = GetComponent<Rigidbody>();
	}

	void FixedUpdate () {

		// Move right/left, up/down, at a faster speed than moving forward.
		jetRB.AddForce( new Vector3(Input.GetAxis ("Horizontal")*speed*5, 0, 0));
		jetRB.AddForce (new Vector3(0, Input.GetAxis ("Vertical")*speed*5, 0));

		// Move player forward a constant speed.
		jetRB.AddForce(moveForward*speed);

	}

}
