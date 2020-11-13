using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class readTextFile : MonoBehaviour {
	public static string[] lineData;
	public string fileName;
	public static bool COMPLETED = false;
	
	// Use this for initialization
	void Start () {
		readInFileWWW();
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	public void readInFileWWW() {
		StartCoroutine(parseStringDataWWW());		
	}
	
	public IEnumerator parseStringDataWWW() {
		WWW www = new WWW("file://" + Application.dataPath + "/../" + fileName);
		
		yield return www;
		// split into lines
		lineData = www.text.Split('\n');
        COMPLETED = true;
	}
	
}

