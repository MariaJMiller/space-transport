using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {

	// Laser shots.
	private GameObject LaserBolt;
	private GameObject Player;
	private Transform BodyGunTopRight;
	private Transform BodyGunBottomRight;
	private Transform BodyGunTopLeft;
	private Transform BodyGunBottomLeft;
	private float laserFireRate = 0.25f;
	private float laserNextFire;

	void Start () {

		LaserBolt = Resources.Load ("Bolt") as GameObject;
		Player = GameObject.Find ("Jet") as GameObject;
		BodyGunTopRight = GameObject.Find("Jet/Gun/ShotSpawnRT").transform;
		BodyGunBottomRight = GameObject.Find ("Jet/Gun001/ShotSpawnRB").transform;
		BodyGunTopLeft = GameObject.Find ("Jet/Gun003/ShotSpawnLT").transform;
		BodyGunBottomLeft = GameObject.Find ("Jet/Gun004/ShotSpawnLB").transform;

	}
	
	void Update () {


		if (Input.GetButton("Fire1") && Time.time > laserNextFire) {

			laserNextFire = Time.time + laserFireRate;
			shoot ();
		}
		
	}

	void shoot () {

		Instantiate(LaserBolt, BodyGunTopRight.position, Player.transform.rotation);
		Instantiate(LaserBolt, BodyGunTopLeft.position, Player.transform.rotation);
		Instantiate(LaserBolt, BodyGunBottomRight.position, Player.transform.rotation);
		Instantiate(LaserBolt, BodyGunBottomLeft.position, Player.transform.rotation);

		animation.Play ("GunsShootingTop");
		animation.Play ("GunsShootingBottom");

		// Instantiate missile guns on body.
		//Instantiate(shot, BodyGunBottomRight.position, BodyGunBottomRight.rotation);
		//Instantiate(shot, BodyGunBottomLeft.position, BodyGunBottomLeft.rotation);

	}
}
