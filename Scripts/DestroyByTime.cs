using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour {

	private float lifetime = 2;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, lifetime);
	}

}
