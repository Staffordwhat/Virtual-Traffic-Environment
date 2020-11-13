using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beep : MonoBehaviour {


    public AudioSource beepSound;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.X))
        {
            beepSound.Play();
        }
	}
}
