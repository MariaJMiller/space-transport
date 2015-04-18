using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {

	// Laser shots.
	private GameObject LaserBolt;
	private GameObject jet;
	private Transform BodyGunTopRight;
	private Transform BodyGunBottomRight;
	private Transform BodyGunTopLeft;
	private Transform BodyGunBottomLeft;
	private float laserFireRate = 0.25f;
	private float laserNextFire;

	// Destroy all shots after this time.
	private float destroyTime = 5.0f;

	void Start () {

		LaserBolt = Instantiate(Resources.Load("whiteLaserBolt", typeof(GameObject))) as GameObject;
		BodyGunTopRight = GameObject.Find("Jet/Gun/ShotSpawnRT").transform;
		BodyGunBottomRight = GameObject.Find ("Jet/Gun001/ShotSpawnRB").transform;
		BodyGunTopLeft = GameObject.Find ("Jet/Gun003/ShotSpawnLT").transform;
		BodyGunBottomLeft = GameObject.Find ("Jet/Gun004/ShotSpawnLB").transform;
	}
	
	void Update () {


		if (Input.GetButton("Fire1")) {

			laserNextFire = Time.time + laserFireRate;

			// Instantiate laser fire.
			Instantiate(LaserBolt, BodyGunTopRight.position, BodyGunTopRight.rotation);
			Instantiate(LaserBolt, BodyGunTopLeft.position, BodyGunTopLeft.rotation);
			Instantiate(LaserBolt, BodyGunBottomRight.position, BodyGunBottomRight.rotation);
			Instantiate(LaserBolt, BodyGunBottomLeft.position, BodyGunBottomLeft.rotation);

			animation.Play ("GunsShootingTop");
			animation.Play ("GunsShootingBottom");

			// Instantiate missile guns on body.
			//Instantiate(shot, BodyGunBottomRight.position, BodyGunBottomRight.rotation);
			//Instantiate(shot, BodyGunBottomLeft.position, BodyGunBottomLeft.rotation);
		}
		
	}

	void shoot () {



	}
}
