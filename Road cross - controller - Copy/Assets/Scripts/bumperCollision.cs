using UnityEngine;
using System.Collections;

public class bumperCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision collision) {
		
		// if hornOnImpact
		this.GetComponent<AudioSource>().Play();
	}
}
