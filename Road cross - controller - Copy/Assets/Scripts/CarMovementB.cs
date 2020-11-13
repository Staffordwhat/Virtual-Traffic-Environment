using UnityEngine;
using System.Collections;

public class CarMovementB : MonoBehaviour
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

    public void triggerCarMove(float bSpeed)
    {
        MOVE_CAR = true;
        speed = bSpeed;
    }

    public void stopCar()
    {
        MOVE_CAR = false;
    }
}

