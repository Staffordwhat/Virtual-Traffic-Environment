using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public bool MOVE_PLAYER;

    void Start ()
    {
        MOVE_PLAYER = false;
    }
	
	// Update is called once per frame
	void Update () {
      
        // var z = Input.GetAxis("Vertical") * Time.deltaTime * 1.50f;

        if (Input.GetAxis("Vertical") > 0 && !MOVE_PLAYER)
        {
            MOVE_PLAYER = true;
        }

        if (MOVE_PLAYER && transform.position.z < 8f )
        {
            transform.Translate(0, 0, 1f * (Time.deltaTime * 1.5f));
        } else
        {
            MOVE_PLAYER = false;
        }

            
        }
        


}
