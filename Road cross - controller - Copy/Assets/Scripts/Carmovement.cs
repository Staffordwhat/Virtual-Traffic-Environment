using UnityEngine;
using System.Collections;

public class Carmovement : MonoBehaviour
{

    public bool MOVE_CAR;
    public float speed;
    void Start()
    {
        MOVE_CAR = false;
        speed = 1f;
    }

    void Update()
    {
        if (MOVE_CAR)
        {
            float translation = Time.deltaTime * constantsMain.ONE_MPH_IN_METRES_SECOND * speed;
            transform.Translate(0, 0, translation);
        }
    }

    public void triggerCarMove(float aSpeed)
    {
        MOVE_CAR = true;
        speed = aSpeed;
    }

    public void stopCar()
    {
        MOVE_CAR = false;
    }
}

