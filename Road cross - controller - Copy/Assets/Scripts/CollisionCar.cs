using UnityEngine;
using System.Collections;

public class CollisionCar : MonoBehaviour
{

    bool collisionA = false;
    bool collisionB = false;
    bool collisionC = false;
    bool collisionD = false;
    bool collisionE = false;
    bool collisionF = false;
    bool collisionG = false;
    bool collisionH = false;
    bool collisionI = false;
    bool collisionJ = false;
    bool collisionK = false;
    bool collision1 = false;
    bool collision2 = false;
    bool collision3 = false;
    bool collision4 = false;
    bool collision5 = false;
    bool collision6 = false;
    bool collision7 = false;
    bool collision8 = false;
    bool collision9 = false;
    bool collision10 = false;
    bool collision11 = false;
  

    void OnTriggerEnter(Collider col)
    {
        //Debug.Log(gameObject.name + "has collidied with" + col.gameObject.name);
        if (col.gameObject.tag == "carA")
        {
            collisionA = true;
        
        }
        if (collisionA == true)
        {
            mainManager.carCollision = 2;
        }

        if (col.gameObject.tag == "carB")
        {
            collisionA = true;

        }
        if (collisionA == true)
        {
            mainManager.carCollision = 2;
        }
        if (col.gameObject.tag == "carC")
        {
            collisionA = true;

        }
        if (collisionA == true)
        {
            mainManager.carCollision = 2;
        }

        if (col.gameObject.tag == "carD")
        {
            collisionA = true;

        }
        if (collisionA == true)
        {
            mainManager.carCollision = 2;
        }

        if (col.gameObject.tag == "carE")
        {
            collisionA = true;

        }
        if (collisionA == true)
        {
            mainManager.carCollision = 2;
        }
        if (col.gameObject.tag == "carF")
        {
            collisionA = true;

        }
        if (collisionA == true)
        {
            mainManager.carCollision = 2;
        }
        if (col.gameObject.tag == "carG")
        {
            collisionA = true;

        }
        if (collisionA == true)
        {
            mainManager.carCollision = 2;
        }
        if (col.gameObject.tag == "carH")
        {
            collisionA = true;

        }
        if (collisionA == true)
        {
            mainManager.carCollision = 2;
        }
        if (col.gameObject.tag == "carI")
        {
            collisionA = true;

        }
        if (collisionA == true)
        {
            mainManager.carCollision = 2;
        }
        if (col.gameObject.tag == "carJ")
        {
            collisionA = true;

        }
        if (collisionA == true)
        {
            mainManager.carCollision = 2;
        }
        if (col.gameObject.tag == "carK")
        {
            collisionA = true;

        }
        if (collisionA == true)
        {
            mainManager.carCollision = 2;
        }
        if (col.gameObject.tag == "car1")
        {
            collisionA = true;

        }
        if (collisionA == true)
        {
            mainManager.carCollision = 2;
        }
        if (col.gameObject.tag == "car2")
        {
            collisionA = true;

        }
        if (collisionA == true)
        {
            mainManager.carCollision = 2;
        }
        if (col.gameObject.tag == "car3")
        {
            collisionA = true;

        }
        if (collisionA == true)
        {
            mainManager.carCollision = 2;
        }
        if (col.gameObject.tag == "car4")
        {
            collisionA = true;

        }
        if (collisionA == true)
        {
            mainManager.carCollision = 2;
        }
        if (col.gameObject.tag == "car5")
        {
            collisionA = true;

        }
        if (collisionA == true)
        {
            mainManager.carCollision = 2;
        }
        if (col.gameObject.tag == "car6")
        {
            collisionA = true;

        }
        if (collisionA == true)
        {
            mainManager.carCollision = 2;
        }
        if (col.gameObject.tag == "car7")
        {
            collisionA = true;

        }
        if (collisionA == true)
        {
            mainManager.carCollision = 2;
        }
        if (col.gameObject.tag == "car8")
        {
            collisionA = true;

        }
        if (collisionA == true)
        {
            mainManager.carCollision = 2;
        }
        if (col.gameObject.tag == "car9")
        {
            collisionA = true;

        }
        if (collisionA == true)
        {
            mainManager.carCollision = 2;
        }
        if (col.gameObject.tag == "car10")
        {
            collisionA = true;

        }
        if (collisionA == true)
        {
            mainManager.carCollision = 2;
        }
        if (col.gameObject.tag == "car11")
        {
            collisionA = true;

        }
        if (collisionA == true)
        {
            mainManager.carCollision = 2;
        }
        Debug.Log(mainManager.carCollision);
        Debug.Log(mainManager.nearMiss);
       
    }
}



        // if (col.gameObject.tag == "carA")
        // {
        //   collisionA = true;
        //   mainManager.carCollision = 1;
        //  }

        //   {

        //   }

        //    if (col.gameObject.tag == "carB")
        //  {
        //        mainManager.carCollision = 2;
        // }
        //  if (col.gameObject.tag == "nearMissB")
        //          {
        //       mainManager.nearMiss = 2;
        //   }
        //    if (col.gameObject.tag == "carC")
        //     {
        //         mainManager.carCollision = 3;
        //    }
        //   if (col.gameObject.tag == "nearMissA")
        //           {
        //       mainManager.nearMiss = 3;
        // }
        //  if (col.gameObject.tag == "carD")
        //   {
        //      mainManager.carCollision = 4;
        //   }
        //   if (col.gameObject.tag == "nearMissA")
        //          {
        //     mainManager.nearMiss = 4;
        //   }
        //   Debug.Log(mainManager.carCollision);
        //   Debug.Log(mainManager.nearMiss);

        //  }
    

