using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public int playerStartingHealth = 100;
	public int playerCurrentHealth;
	public Slider healthSlider;

	void Awake () {

		playerCurrentHealth = playerStartingHealth;
	}

	public int DamagePlayer (int damage) {

		playerCurrentHealth -= damage;

		healthSlider.value = playerCurrentHealth;

		return playerCurrentHealth;
	}
}
