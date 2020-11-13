using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CueSoundTwo : MonoBehaviour {

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
        if (other.gameObject.tag == "cue2")
        {
            Debug.Log("registered2");
            audio.Play();
            sound = true;
        }
    }
}