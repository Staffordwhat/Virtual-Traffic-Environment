using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;


public class parseSetupFile : MonoBehaviour
{
	
	public static List<experimentDetail>  experimentDetails  = new List<experimentDetail>();
    public static float TRIAL_RUN_TIME = 15;


    static GameObject carA;

    void Start()
    {
        carA = GameObject.Find("carA");


    }

    void Update()
    {

    }
	
	// Update is called once per frame
	public static void parseData() {
		
		if (readTextFile.COMPLETED) {
			for (int i=0; i<readTextFile.lineData.Length; i++) {
				
				experimentDetail nextTrial = new experimentDetail();
				
				string nextLine = readTextFile.lineData[i];
				
				nextLine = nextLine.Trim();				
				
				if (nextLine.StartsWith("#") || String.IsNullOrEmpty(nextLine.Trim())) {
					// it is a comment so ignore it
				} else {

                    string[] next = nextLine.Split(new char[] { '=' });
                    if (next.Length > 1)
                    {
                        if (next[0].Equals(constantsMain.TRIAL_RUN_TIME))
                        {
                            TRIAL_RUN_TIME = float.Parse(next[1]);
                        } 
                    }
                    else
                    {
                        try
                        {
                           string[] subwords = nextLine.Split(new char[] { '\t' });

                            // get the details for the next trial
                            nextTrial.setTrialNumber(Convert.ToInt32(subwords[0]));
                            nextTrial.setCarAStartPosition(new Vector3(float.Parse(subwords[5]), carA.transform.position.y, float.Parse(subwords[6])));
                            nextTrial.setCarASpeed(float.Parse(subwords[3]));
                            nextTrial.setCarBStartPosition(new Vector3(float.Parse(subwords[15]), carA.transform.position.y, float.Parse(subwords[6])));
                            nextTrial.setCarCStartPosition(new Vector3(float.Parse(subwords[16]), carA.transform.position.y, float.Parse(subwords[6])));
                            nextTrial.setCarDStartPosition(new Vector3(float.Parse(subwords[7]), carA.transform.position.y, float.Parse(subwords[6])));
                            nextTrial.setCarEStartPosition(new Vector3(float.Parse(subwords[17]), carA.transform.position.y, float.Parse(subwords[6])));
                            nextTrial.setCarFStartPosition(new Vector3(float.Parse(subwords[18]), carA.transform.position.y, float.Parse(subwords[6])));
                            nextTrial.setCarGStartPosition(new Vector3(float.Parse(subwords[19]), carA.transform.position.y, float.Parse(subwords[6])));
                            nextTrial.setCarHStartPosition(new Vector3(float.Parse(subwords[20]), carA.transform.position.y, float.Parse(subwords[6])));
                            nextTrial.setCarIStartPosition(new Vector3(float.Parse(subwords[21]), carA.transform.position.y, float.Parse(subwords[6])));
                            nextTrial.setCarJStartPosition(new Vector3(float.Parse(subwords[22]), carA.transform.position.y, float.Parse(subwords[6])));
                            nextTrial.setCarKStartPosition(new Vector3(float.Parse(subwords[23]), carA.transform.position.y, float.Parse(subwords[6])));
                            nextTrial.setCar1StartPosition(new Vector3(float.Parse(subwords[1]), carA.transform.position.y, float.Parse(subwords[2])));
                            nextTrial.setCar2StartPosition(new Vector3(float.Parse(subwords[10]), carA.transform.position.y, float.Parse(subwords[2])));
                            nextTrial.setCar3StartPosition(new Vector3(float.Parse(subwords[11]), carA.transform.position.y, float.Parse(subwords[2])));
                            nextTrial.setCar4StartPosition(new Vector3(float.Parse(subwords[4]), carA.transform.position.y, float.Parse(subwords[2])));
                            nextTrial.setCar5StartPosition(new Vector3(float.Parse(subwords[12]), carA.transform.position.y, float.Parse(subwords[2])));
                            nextTrial.setCar6StartPosition(new Vector3(float.Parse(subwords[13]), carA.transform.position.y, float.Parse(subwords[2])));
                            nextTrial.setCar7StartPosition(new Vector3(float.Parse(subwords[14]), carA.transform.position.y, float.Parse(subwords[2])));
                            nextTrial.setCar8StartPosition(new Vector3(float.Parse(subwords[24]), carA.transform.position.y, float.Parse(subwords[2])));
                            nextTrial.setCar9StartPosition(new Vector3(float.Parse(subwords[25]), carA.transform.position.y, float.Parse(subwords[2])));
                            nextTrial.setCar10StartPosition(new Vector3(float.Parse(subwords[26]), carA.transform.position.y, float.Parse(subwords[2])));
                            nextTrial.setCar11StartPosition(new Vector3(float.Parse(subwords[27]), carA.transform.position.y, float.Parse(subwords[2])));
                            nextTrial.setTrafficNumber(float.Parse(subwords[8]));
                            nextTrial.setCarBSpeed(float.Parse(subwords[9]));
                            experimentDetails.Add(nextTrial);
                        }
                        catch (Exception e)
                        {
                            Debug.Log("PARSE FILE ERROR " + e.ToString());
                        }
                    }
				}
			}
		}
	
	}
}
