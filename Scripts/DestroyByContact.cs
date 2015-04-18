using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {

	public GameObject asteriodExplosion;
	public GameObject playerExplosion;
	private int scoreValue = 10;

	private GameController gameController;

	void Start () {

		GameObject gameControllerObject = GameObject.FindWithTag("GameController");

		if(gameControllerObject != null) {
			gameController = gameControllerObject.GetComponent <GameController>();
		}

		if(gameControllerObject == null) {
			Debug.Log ("Could not find 'GameController' Script");
		}
	}

	void OnTriggerEnter (Collider other) {

		if (other.tag == "Boundary") {
			return;
		}
		Instantiate(asteriodExplosion, transform.position, transform.rotation);

		if (other.tag == "Player") {
			Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
		}
		gameController.AddScore(scoreValue);
		Destroy (other.gameObject);
		Destroy (gameObject);
	}
}
