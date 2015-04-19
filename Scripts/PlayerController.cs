using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// The Player object
	private float speed = 40;
	private float tilt = 3;
	//private Vector3 moveForward = new Vector3(0, 0, 1);
	public Rigidbody player;

	void Start () {

		player = GetComponent<Rigidbody>();
	}

	void FixedUpdate () {

		// Move right/left, up/down, at a faster speed than moving forward.
		player.AddForce( new Vector3(Input.GetAxis ("Horizontal")*speed, 0, 0));
		player.AddForce (new Vector3(0, Input.GetAxis ("Vertical")*speed, 0));

		player.AddForce(-player.transform.up*speed, ForceMode.Acceleration);

		// The x rotation must be set at 270 or the player will face down.
		player.rotation = Quaternion.Euler (270, 0, player.velocity.x * tilt);

	}

}
