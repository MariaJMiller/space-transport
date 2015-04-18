using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public GameObject hazard;
 	private GameObject Player;
	private Transform playerPosition;
	private float spawnRate = 3;
	private float spawnNext;
	private float spawnX = 250;
	private float spawnY = 40;
	private float spawnZMax = 300;
	private float spawnZMin = 200;

	private int hazardCount = 8;

	public Text scoreText;
	private int score;

	// Use this for initialization
	void Start () {

		score = 0;
		UpdateScore ();
		Player = GameObject.Find ("Jet") as GameObject;
		playerPosition = Player.transform;
	
	}

	void FixedUpdate () {

		if (Time.time > spawnNext) {
			spawnNext  = Time.time + spawnRate;
			SpawnWaves ();
		}
	}
	
	void SpawnWaves () {

		for (int i = 0; i < hazardCount; i++) {
			Vector3 spawnPosition = new Vector3 (Random.Range(-spawnX, spawnX), 0, 
			                                     playerPosition.position.z + Random.Range (spawnZMin, spawnZMax));
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate(hazard, spawnPosition, spawnRotation);
		}
	}

	public void AddScore (int newScoreValue) {
		score += newScoreValue;
		UpdateScore ();
	}

	void UpdateScore () {
		scoreText.text = "Score: " + score;
	}
}
