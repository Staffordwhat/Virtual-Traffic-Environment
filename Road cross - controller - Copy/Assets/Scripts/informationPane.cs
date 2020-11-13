using UnityEngine;
using System.Collections;

public class informationPane : MonoBehaviour {

	public static string infoPane;
	
	// Use this for initialization
	void Start () {
		infoPane = "";
	}
	
	// Update is called once per frame
	void Update () {
	
	}	
	
	void OnGUI() {
		GUI.Label(new Rect(21,10,400,20), infoPane);
	}
}
