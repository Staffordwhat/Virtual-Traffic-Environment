using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;

public class saveExperimentData : MonoBehaviour {

	private static ArrayList myArrayList;
	
	public static string FILE_EXTENSION = ".txt";
	public static string SEPERATOR = "_";

	// Use this for initialization
	void Start () {
		myArrayList = new ArrayList();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public static void clearData() {
		myArrayList = new ArrayList();
	}
	
	/* 
	 * Save a data point
	 * Records the current time but also the current sample count to ensure absolute accuracy
	 */
	public static void saveDataPoint(dataExperimentSavePoint nextPoint) {

        // might give same value.. use in conjunction with sampleCounter
        double acurrentTime = Time.realtimeSinceStartup;
        DateTime currentSysTime = System.DateTime.Now;

        nextPoint.setCurrentTime(acurrentTime);
        nextPoint.setCurrentSysTime(currentSysTime);

        myArrayList.Add(nextPoint);
		
	}
	
	/*
	 * 	Save all data to a file
	 **/
	public static void saveDataToFile(experimentDetail currentExperimentDetail) {
		
		string SEPARATOR = "\t";
		string fileName  = mainManager.participantIDText + "_" + mainManager.currentTrial.getTrialNumber() + FILE_EXTENSION;
			
		StreamWriter sr = new StreamWriter(Application.dataPath + "/" + fileName, true);
		
		string trialData = "";
		
		trialData += "EXPERIMENTAL DATA\n############################################\n";
		trialData += "Trial Number: " + currentExperimentDetail.getTrialNumber() + "\n";	
		trialData += "Car3 Start Position: " + currentExperimentDetail.getCar3StartPosition() + "\n";
        trialData += "CarC Start Position: " + currentExperimentDetail.getCarCStartPosition() + "\n";
        trialData += "Car A Speed: " + currentExperimentDetail.getCarASpeed() + "\n";
        trialData += "Car 4 Distance:" + currentExperimentDetail.getCar4StartPosition() + "\n";
        trialData += "Car D Distance:" + currentExperimentDetail.getCarDStartPosition() + "\n";
        trialData += "Trial Finish: " + System.DateTime.Now.ToString(constantsMain.DATE_FORMAT);
        trialData += "Collision Indicator: " + mainManager.carCollision;
        trialData += "Near Miss Number: " + mainManager.nearMiss;
        trialData += "Cross" + mainManager.cross;
		sr.WriteLine(trialData);		
		

		sr.WriteLine("currentTime" + SEPARATOR + "currentSysTime" + SEPARATOR + "sampleCounter" +  SEPARATOR + "car3CurrentPosition.x" + SEPARATOR + "car3CurrentPosition.y" + SEPARATOR + "car3CurrentPosition.z" + SEPARATOR +  "car4CurrentPosition.x" + SEPARATOR + "car4CurrentPosition.y" + SEPARATOR + "car4CurrentPosition.z" + SEPARATOR +  "carCCurrentPosition.x" + SEPARATOR + "carCCurrentPosition.y" + SEPARATOR + "carCCurrentPosition.z" + SEPARATOR + "carDCurrentPosition.x" + SEPARATOR + "carDCurrentPosition.y" + SEPARATOR + "carDCurrentPosition.z" + SEPARATOR + "PlayerX" + SEPARATOR + "PlayerY" + SEPERATOR + "PlayerZ" + SEPARATOR + "RotateX" + SEPARATOR + "RotateY" + SEPERATOR + "RotateZ");
		foreach (dataExperimentSavePoint aValue in myArrayList) {
			sr.WriteLine(aValue.toString());
		}
        sr.Flush(); 
		myArrayList.Clear();	
	}
	
}
