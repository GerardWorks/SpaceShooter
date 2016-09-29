using UnityEngine;
using System.Collections;

public class destroyByTime : MonoBehaviour {

	public float Lifetime;
	// Use this for initialization
	void Start () {
		Destroy (gameObject,Lifetime);
	
	}
	

}
