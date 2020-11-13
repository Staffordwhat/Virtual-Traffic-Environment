using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayTenMetres : MonoBehaviour {

    public AudioSource audio;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "car4")
        {
            audio.Play();
        }
    }
}
