using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour {
	
	// Destroy shots as they exit boundary attached to player
	void OnTriggerExit (Collider other) {
		Destroy(other.gameObject);
	}
}
