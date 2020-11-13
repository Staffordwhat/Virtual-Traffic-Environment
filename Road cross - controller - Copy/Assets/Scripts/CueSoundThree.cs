using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CueSoundThree : MonoBehaviour {

    public AudioSource audio;
    public bool sound;

    // Use this for initialization
    void Start()
    {
        sound = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "cue3")
        {
            Debug.Log("registered3");
            audio.Play();
            sound = true;
        }
    }
}