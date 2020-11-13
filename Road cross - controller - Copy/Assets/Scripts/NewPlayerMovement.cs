using UnityEngine;
using System.Collections;

public class NewPlayerMovement : MonoBehaviour
{
    public bool MOVE_PLAYER;
    public float speed = 1.5f;
    void Start()
    {
        MOVE_PLAYER = false;
        speed = 1.5f;
    }

    void Update()
    {
        
        if (Input.GetButtonDown("Vertical"))
        {
            float translation = Time.deltaTime * speed;
            transform.Translate(0, 0, translation);
        }
    }



}



