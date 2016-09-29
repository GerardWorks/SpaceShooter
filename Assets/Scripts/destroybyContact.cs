using UnityEngine;
using System.Collections;

public class destroybyContact : MonoBehaviour {

	public GameObject explosion;
	public GameObject playerdeath;

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Boundary") {
			return;
		}
		Destroy(other.gameObject);
		Destroy (gameObject);
		Instantiate (explosion, transform.position, transform.rotation);
		if (other.tag == "Player") {
			Instantiate (playerdeath, other.transform.position, other.transform.rotation);
		}

	}



}
