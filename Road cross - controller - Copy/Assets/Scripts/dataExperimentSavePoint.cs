using UnityEngine;
using System.Collections;
using System;

public class dataExperimentSavePoint  {

	// current system Time of snapshot
	private double currentTime;
	private int sampleCounter;
	private DateTime currentSysTime;
    private Vector3 car3CurrentPosition;
    private Vector3 car4CurrentPosition;
    private Vector3 carCCurrentPosition;
    private Vector3 carDCurrentPosition;
    private Vector3 playerPosition;
    private Vector3 observerCurrentRotation;

    public dataExperimentSavePoint()
    {

    }

    public int getSampleCounter()
    {
        return sampleCounter;
    }

    public void setSampleCounter(int acount)
    {
        sampleCounter = acount;
    }

    public double getCurrentTime()
    {
        return currentTime;
    }

    public void setCurrentTime(double aCurTime)
    {
        currentTime = aCurTime;
    }

    public DateTime getCurrentSysTime()
    {
        return currentSysTime;
    }

    public void setCurrentSysTime(DateTime aTime)
    {
        currentSysTime = aTime;
    }

    public void setCarDCurrentPosition(Vector3 dpos)
    {
        carDCurrentPosition = dpos;
    }

    public Vector3 getCarDCurrentPosition()
    {
        return carDCurrentPosition;
    }

    public void setCar3CurrentPosition(Vector3 apos3)
    {
        car3CurrentPosition = apos3;
    }

    public Vector3 getCar3CurrentPosition()
    {
        return car3CurrentPosition;
    }

    public void setCar4CurrentPosition(Vector3 apos4)
    {
        car4CurrentPosition = apos4;
    }

    public Vector3 getCar4CurrentPosition()
    {
        return car4CurrentPosition;
    }

    public void setCarCCurrentPosition(Vector3 cpos)
    {
        carCCurrentPosition = cpos;
    }

    public Vector3 getCarCCurrentPosition()
    {
        return carCCurrentPosition;
    }

    public void setPlayerPosition(Vector3 apos)
    {
        playerPosition = apos;
    }

    public Vector3 getPlayerPosition()
    {
        return playerPosition;
    }

    public void setObserverCurrentRotation(Vector3 aRotation)
    {
        observerCurrentRotation = aRotation;
    }

    public Vector3 getObserverCurrentRotation()
    {
        return observerCurrentRotation;
    }




    public dataExperimentSavePoint(int aSampleCounter, double acurrentTime, DateTime acurrentSysTime, Vector3 acar3CurrentPosition, Vector3 acar4CurrentPosition, Vector3 acarCCurrentPosition, Vector3 acarDCurrentPosition, Vector3 aPlayerPos, Vector3 aRotation) {
		currentTime = acurrentTime;
		currentSysTime = acurrentSysTime;
		sampleCounter = aSampleCounter;
		car3CurrentPosition = acar3CurrentPosition;
        car4CurrentPosition = acar4CurrentPosition;
        carCCurrentPosition = acarCCurrentPosition;
        carDCurrentPosition = acarDCurrentPosition;
        playerPosition = aPlayerPos;
        observerCurrentRotation = aRotation;

    }
	
	public string toString() {		
		string SEPARATOR = "\t";
		
		string result = currentTime + SEPARATOR;
		result += currentSysTime.ToString(constantsMain.DATE_FORMAT) + SEPARATOR;
		result += sampleCounter + SEPARATOR;
		result += car3CurrentPosition.x + SEPARATOR + car3CurrentPosition.y + SEPARATOR + car3CurrentPosition.z + SEPARATOR;
        result += car4CurrentPosition.x + SEPARATOR + car4CurrentPosition.y + SEPARATOR + car4CurrentPosition.z + SEPARATOR;
        result += carCCurrentPosition.x + SEPARATOR + carCCurrentPosition.y + SEPARATOR + carCCurrentPosition.z + SEPARATOR;
        result += carDCurrentPosition.x + SEPARATOR + carDCurrentPosition.y + SEPARATOR + carDCurrentPosition.z + SEPARATOR;
        result += playerPosition.x + SEPARATOR + playerPosition.y + SEPARATOR + playerPosition.z + SEPARATOR;
        result += observerCurrentRotation.z + SEPARATOR + observerCurrentRotation.y + SEPARATOR + observerCurrentRotation.x + SEPARATOR;

        return result;		
	}		
	
}
