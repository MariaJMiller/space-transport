using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	private float speed = 40;
	private float tilt = 2;

	public Rigidbody player;

	void Start () {

		player = GetComponent<Rigidbody>();
	}

	void FixedUpdate () {

		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");

		// Move right/left, up/down, at a faster speed than moving forward.
		player.AddForce(horizontal*speed, 0, 0);
		player.AddForce (0, vertical*speed, 0);

		player.AddForce(-player.transform.up*speed, ForceMode.Acceleration);

		// The x rotation must be set at 270 or the player will face down.
		player.rotation = Quaternion.Euler (270+horizontal, 0, player.velocity.x * tilt);

	}

}
