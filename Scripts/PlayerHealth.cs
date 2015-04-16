using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public int startingHealth = 100;
	public int currentHealth;
	public Slider healthSlider;

	PlayerController playerController;
	// PlayerShooting playerShooting;
	bool isDead = false;
	bool damaged = false;

	// Set references and initial health
	void Awake () {

		playerController = GetComponent<PlayerController>();

		currentHealth = startingHealth;
	}

	public void TakeDamage (int damage) {

		damaged = true;

		// Subtract damage from health.
		currentHealth -= damage;

		healthSlider.value = currentHealth;

		if (currentHealth <= 0 && !isDead) {
			Die ();
		}
	}

	public void Die () {

		// Don't call this function again.
		isDead = true;

		// TODO
		// Destroy jet object and return to game menu.
	}
}
