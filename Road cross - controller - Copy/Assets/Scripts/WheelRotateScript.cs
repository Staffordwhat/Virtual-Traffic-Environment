using UnityEngine;
using System.Collections;

public class WheelRotateScript : MonoBehaviour {
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		float speed = 100f;
		
		float wheelRadius = 0.5f;
		
		float distanceTraveled = speed * Time.deltaTime;

		float rotationInRadians = distanceTraveled / wheelRadius;
	
		float rotationInDegrees = rotationInRadians * Mathf.Rad2Deg;

		this.transform.Rotate(0, rotationInDegrees, 0);
		// this.transform.RotateAroundLocal(new Vector3(1,0,0), 100);
	
	}
}
