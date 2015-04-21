using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	private GameObject hazard;
 	private GameObject Player;
	private Transform playerPosition;
	private float spawnWait = 0.5f;
	private float startWait = 1;
	private float waveWait = 4;
	private float spawnX = 50; 
	private float spawnY = 20;
	private float spawnZMax = 300;
	private float spawnZMin = 200;

	private int hazardCount = 20;

	public Text scoreText;
	public Text restartText;
	public Text gameOverText;

	private bool gameOver;
	private bool restart;
	private int score;
	private float scaleValue;
	private Vector3 scale = new Vector3 (1, 1, 1);

	// Use this for initialization
	void Start () {

		score = 0;
		gameOver = false;
		restart = false;
		restartText.text = "";
		gameOverText.text = "";
		UpdateScore ();
		hazard = Resources.Load ("Asteroid") as GameObject;
		Player = GameObject.FindGameObjectWithTag ("Player") as GameObject;
		playerPosition = Player.transform;

		StartCoroutine(SpawnWaves ());
	
	}

	void Update () {

		if (restart) {

			if (Input.GetKeyDown (KeyCode.R)) {
				Application.LoadLevel(Application.loadedLevel);
			}
		}
	}
	
	IEnumerator SpawnWaves () {

		yield return new WaitForSeconds (startWait);

		while (true) {

			for (int i = 0; i < hazardCount; i++) {

				Vector3 spawnPosition = new Vector3 (Random.Range(-spawnX, spawnX), Random.Range(-spawnY, spawnY), 
				                                     playerPosition.position.z + Random.Range (spawnZMin, spawnZMax));
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate(hazard, spawnPosition, spawnRotation);

				scaleValue = Random.Range (1, 3);
				hazard.transform.localScale = scale * scaleValue;

				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);

			if (gameOver) {
				restartText.text = "Press 'R' for restart";
				restart = true;
				break;
			}
		}
	}

	public void AddScore (int newScoreValue) {
		score += newScoreValue;
		UpdateScore ();
	}

	public void GameOver () {

		gameOverText.text = "Game Over";
		gameOver = true;
	}

	void UpdateScore () {
		scoreText.text = "Score: " + score;
	}
	
}
