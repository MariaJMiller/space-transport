using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {

	public GameObject asteriodExplosion;
	public GameObject playerExplosion;
	private int scoreValue = 10;
	private int damageAmount = 10;
	private int playerHealthValue = 100;

	private GameController gameController;
	private PlayerHealth playerHealth;

	void Start () {

		playerHealth = GameObject.FindWithTag ("Player").GetComponent <PlayerHealth>();
		playerHealthValue = playerHealth.playerStartingHealth;

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
		else if (other.tag == "Player") {
			playerHealthValue = playerHealth.DamagePlayer(damageAmount);
			if (playerHealthValue <= 0) {
				Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
				Destroy (other.gameObject);
				gameController.GameOver();
			}
		}
		else {

			Instantiate(asteriodExplosion, transform.position, transform.rotation);
			gameController.AddScore(scoreValue);
			Destroy (other.gameObject);
			Destroy (gameObject);
		}
	}
}
