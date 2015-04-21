using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {

	// Laser shots.
	private GameObject LaserBolt;
	private GameObject Player;

	private Transform LaserGunTopRight0;
	private Transform LaserGunTopRight1;
	private Transform LaserGunBottomRight0;
	private Transform LaserGunBottomRight1;
	private Transform LaserGunTopLeft0;
	private Transform LaserGunTopLeft1;
	private Transform LaserGunBottomLeft0;
	private Transform LaserGunBottomLeft1;
	
	private float laserFireRate = 0.25f;
	private float laserNextFire;

	void Start () {

		LaserBolt = Resources.Load ("Bolt") as GameObject;
		Player = GameObject.FindGameObjectWithTag ("Player") as GameObject;

		LaserGunTopRight0 = GameObject.Find("Jet/Jet/Gun/LaserTopRight0").transform;
		LaserGunTopRight1 = GameObject.Find ("Jet/Jet/Gun/LaserTopRight1").transform;
		LaserGunBottomRight0 = GameObject.Find ("Jet/Jet/Gun001/LaserBottomRight0").transform;
		LaserGunBottomRight1 = GameObject.Find ("Jet/Jet/Gun001/LaserBottomRight1").transform;

		LaserGunTopLeft0 = GameObject.Find ("Jet/Jet/Gun003/LaserTopLeft0").transform;
		LaserGunTopLeft1 = GameObject.Find ("Jet/Jet/Gun003/LaserTopLeft1").transform;
		LaserGunBottomLeft0 = GameObject.Find ("Jet/Jet/Gun004/LaserBottomLeft0").transform;
		LaserGunBottomLeft1 = GameObject.Find ("Jet/Jet/Gun004/LaserBottomLeft1").transform;

	}
	
	void Update () {

		if (Input.GetButton("Fire1") && Time.time > laserNextFire) {

			laserNextFire = Time.time + laserFireRate;
			shoot ();
		}
		
	}

	void shoot () {

		Instantiate(LaserBolt, LaserGunTopRight0.position, Player.transform.rotation);
		Instantiate(LaserBolt, LaserGunTopRight1.position, Player.transform.rotation);
		Instantiate(LaserBolt, LaserGunBottomRight0.position, Player.transform.rotation);
		Instantiate(LaserBolt, LaserGunBottomRight1.position, Player.transform.rotation);

		Instantiate(LaserBolt, LaserGunTopLeft0.position, Player.transform.rotation);
		Instantiate(LaserBolt, LaserGunTopLeft1.position, Player.transform.rotation);
		Instantiate(LaserBolt, LaserGunBottomLeft0.position, Player.transform.rotation);
		Instantiate(LaserBolt, LaserGunBottomLeft1.position, Player.transform.rotation);

		animation.Play ("GunsShootingTop");
		animation.Play ("GunsShootingBottom");

		// Instantiate missile guns on body.
		//Instantiate(shot, BodyGunBottomRight.position, BodyGunBottomRight.rotation);
		//Instantiate(shot, BodyGunBottomLeft.position, BodyGunBottomLeft.rotation);

	}
}
