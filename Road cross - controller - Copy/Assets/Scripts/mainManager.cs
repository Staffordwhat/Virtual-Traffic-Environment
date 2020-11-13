using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class mainManager : MonoBehaviour {

    // keep track of where we are in experiment flow
    public static constantsMain.GAMESTATE currentGameState;
    public GameObject Cube;
    public GameObject car1;
    public GameObject car2;
    public GameObject car3;
    public GameObject car4;
    public GameObject car5;
    public GameObject car6;
    public GameObject car7;
    public GameObject car8;
    public GameObject car9;
    public GameObject car10;
    public GameObject car11;
    public GameObject carA;
    public GameObject carB;
    public GameObject carC;
    public GameObject carD;
    public GameObject carE;
    public GameObject carF;
    public GameObject carG;
    public GameObject carH;
    public GameObject carI;
    public GameObject carJ;
    public GameObject carK;
    public GameObject player;
    private GameObject headset;
    private GameObject intersense;
    public float currentTraffic;
    public static int carCollision = 0;
    public static int nearMiss = 0;
    public static int cross = 0;
    public int currentTrialNumber;
    public static experimentDetail currentTrial;
    public static int sampleCounter;
    public float Speed;
    public float Distance;
    public float TTC;
    public bool TTCCondition;
    public bool DistanceCondition;
    public bool DistOn;
    public bool TTCOn;

    public GameObject TTC1;
    public AudioSource TTC1Sound;
    public GameObject TTC2;
    public AudioSource TTC2Sound;
    public GameObject TTC3;
    public AudioSource TTC3Sound;
    public AudioClip impact;

    public float DistanceOnline;
    public float TTCOnline;
    public bool playsound1;
    public bool playsound2;
    public bool playsound3;
    public GameObject tenMetres;
    public GameObject twnetyMetres;
    public GameObject thirtyMetres;

    public Text trialInterimText;

    public Text participantID;
    GameObject submitPID;
    GameObject inputPID;

    public static string participantIDText;

    public void setParticipantID ()
    {
        participantIDText = participantID.text;
        submitPID.SetActive(false);
        inputPID.SetActive(false);

    }





    // Use this for initialization
    void Start () {
        DistOn = false;
        TTCOn = false;
        playsound1 = false;
        playsound2 = false;
        playsound3 = false;

        //TTCOnline = 0f;
        DistanceOnline = 0f;

        submitPID = GameObject.Find("submitPID");
        inputPID = GameObject.Find("inputPID");

        // get reference to any objects we need to move or record or control
        car1 = GameObject.Find(constantsMain.CAR_1_NAME);

        car2 = GameObject.Find(constantsMain.CAR_2_NAME);

        car3 = GameObject.Find(constantsMain.CAR_3_NAME);

        car4 = GameObject.Find(constantsMain.CAR_4_NAME);

        car5 = GameObject.Find(constantsMain.CAR_5_NAME);

        car6 = GameObject.Find(constantsMain.CAR_6_NAME);

        car7 = GameObject.Find(constantsMain.CAR_7_NAME);

        car8 = GameObject.Find(constantsMain.CAR_8_NAME);

        car9 = GameObject.Find(constantsMain.CAR_9_NAME);

        car10 = GameObject.Find(constantsMain.CAR_10_NAME);

        car11 = GameObject.Find(constantsMain.CAR_11_NAME);

        carA = GameObject.Find(constantsMain.CAR_A_NAME);

        carB = GameObject.Find(constantsMain.CAR_B_NAME);

        carC = GameObject.Find(constantsMain.CAR_C_NAME);

        carD = GameObject.Find(constantsMain.CAR_D_NAME);

        carE = GameObject.Find(constantsMain.CAR_E_NAME);

        carF = GameObject.Find(constantsMain.CAR_F_NAME);

        carG = GameObject.Find(constantsMain.CAR_G_NAME);

        carH = GameObject.Find(constantsMain.CAR_H_NAME);

        carI = GameObject.Find(constantsMain.CAR_I_NAME);

        carJ = GameObject.Find(constantsMain.CAR_J_NAME);

        carK = GameObject.Find(constantsMain.CAR_K_NAME);


        TTC1 = GameObject.Find("TTC1");
        TTC2 = GameObject.Find("TTC2");
        TTC3 = GameObject.Find("TTC3");


        player = GameObject.Find(constantsMain.PLAYER_NAME);

        headset = GameObject.Find("Camera");

        intersense = GameObject.Find("intersenseCameraController");


        currentGameState = constantsMain.GAMESTATE.WAIT_CONFIG;

        currentTrialNumber = -1;
        sampleCounter = 0;


   

    }

    // Update is called once per frame
    void FixedUpdate () {

        DistanceOnline = car4.transform.position.x;

        TTCOnline = DistanceOnline / Speed;


        if (TTCOn == true)
        {

            if (TTCOnline < 7 || TTCOnline == 7 && TTCOnline > 6)
            {
                TTC1.SetActive(true);
            }

            if (TTCOnline < 3.5 || TTCOnline == 3.5 && TTCOnline > 3)
            {
                TTC2.SetActive(true);
            }


            if (TTCOnline < 1.75 || TTCOnline == 1.75)
            {
                TTC3.SetActive(true);
            }
        }

        if(DistOn == true)
        {
            tenMetres.SetActive(true);
            twnetyMetres.SetActive(true);
            thirtyMetres.SetActive(true);
            
        }

        else
        {
            tenMetres.SetActive(false);
            twnetyMetres.SetActive(false);
            thirtyMetres.SetActive(false);
        }

        // Set the displayed text to be the word "Score" followed by the score value.

        // read in experiment parameters

        switch (currentGameState)
        {
           case constantsMain.GAMESTATE.PARSE_CONFIG:
                Debug.Log("PARSE_CONFIG");
                if (currentGameState != constantsMain.GAMESTATE.PARSE_CONFIG_WAIT)
                {
                    currentGameState = constantsMain.GAMESTATE.PARSE_CONFIG_WAIT;
                    parseSetupFile.parseData();
                    currentGameState = constantsMain.GAMESTATE.TRIAL_INITIALISE;
                }
break;

            case constantsMain.GAMESTATE.WAIT_CONFIG:

                if (readTextFile.COMPLETED)
                {
                    currentGameState = constantsMain.GAMESTATE.PARSE_CONFIG;
                }
                break;
            case constantsMain.GAMESTATE.TRIAL_INITIALISE:
                Debug.Log("TRIAL INITIALISE");
                // setup next trial
                initialiseTrial();
                break;
            case constantsMain.GAMESTATE.WAIT_INPUT:
                Debug.Log("WAIT_INPUT");
               setParticipantID();
                break;
            case constantsMain.GAMESTATE.TRIAL_WAIT_START:
                if (Input.GetKeyDown(KeyCode.X))
                {

                    car1.SetActive(true);
                    car2.SetActive(true);
                    car3.SetActive(true);
                    car4.SetActive(true);
                    car5.SetActive(true);
                    car6.SetActive(true);
                    car7.SetActive(true);
                    car8.SetActive(true);
                    car9.SetActive(true);
                    car10.SetActive(true);
                    car11.SetActive(true);
                    carA.SetActive(true);
                    carA.SetActive(true);
                    carB.SetActive(true);
                    carC.SetActive(true);
                    carD.SetActive(true);
                    carE.SetActive(true);
                    carF.SetActive(true);
                    carG.SetActive(true);
                    carH.SetActive(true);
                    carI.SetActive(true);
                    carJ.SetActive(true);
                    carK.SetActive(true);

                    intersense.GetComponent<PlayerMovement>().enabled = true;

                    currentGameState = constantsMain.GAMESTATE.TRIAL_START;



                }

                else
                {
                    // set cars to be visible

                    car1.SetActive(false);
                    car2.SetActive(false);
                    car3.SetActive(false);
                    car4.SetActive(false);
                    car5.SetActive(false);
                    car6.SetActive(false);
                    car7.SetActive(false);
                    car8.SetActive(false);
                    car9.SetActive(false);
                    car10.SetActive(false);
                    car11.SetActive(false);
                    carA.SetActive(false);
                    carB.SetActive(false);
                    carC.SetActive(false);
                    carD.SetActive(false);
                    carE.SetActive(false);
                    carF.SetActive(false);
                    carG.SetActive(false);
                    carH.SetActive(false);
                    carI.SetActive(false);
                    carJ.SetActive(false);
                    carK.SetActive(false);
                    intersense.GetComponent<PlayerMovement>().enabled = false;

                }


                break;
            case constantsMain.GAMESTATE.TRIAL_START:
                Debug.Log("TRIAL STARTING");
                if (currentGameState != constantsMain.GAMESTATE.TRIAL_RUNNING)
                {
                    currentGameState = constantsMain.GAMESTATE.TRIAL_RUNNING;
                    // kick off trial
                    // get cars & player moving
                    trialInterimText.text = "";


                    car1.GetComponent<CarMovementB>().triggerCarMove(currentTrial.getCarBSpeed());
                    car2.GetComponent<CarMovementB>().triggerCarMove(currentTrial.getCarBSpeed());
                    car3.GetComponent<CarMovementB>().triggerCarMove(currentTrial.getCarBSpeed());
                    car4.GetComponent<CarMovementB>().triggerCarMove(currentTrial.getCarBSpeed());
                    car5.GetComponent<CarMovementB>().triggerCarMove(currentTrial.getCarBSpeed());
                    car6.GetComponent<CarMovementB>().triggerCarMove(currentTrial.getCarBSpeed());
                    car7.GetComponent<CarMovementB>().triggerCarMove(currentTrial.getCarBSpeed());
                    car8.GetComponent<CarMovementB>().triggerCarMove(currentTrial.getCarBSpeed());
                    car9.GetComponent<CarMovementB>().triggerCarMove(currentTrial.getCarBSpeed());
                    car10.GetComponent<CarMovementB>().triggerCarMove(currentTrial.getCarBSpeed());
                    car11.GetComponent<CarMovementB>().triggerCarMove(currentTrial.getCarBSpeed());
                    carA.GetComponent<Carmovement>().triggerCarMove(currentTrial.getCarASpeed());
                    carB.GetComponent<Carmovement>().triggerCarMove(currentTrial.getCarASpeed());
                    carC.GetComponent<Carmovement>().triggerCarMove(currentTrial.getCarASpeed());
                    carD.GetComponent<Carmovement>().triggerCarMove(currentTrial.getCarASpeed());
                    carE.GetComponent<Carmovement>().triggerCarMove(currentTrial.getCarASpeed());
                    carF.GetComponent<Carmovement>().triggerCarMove(currentTrial.getCarASpeed());
                    carG.GetComponent<Carmovement>().triggerCarMove(currentTrial.getCarASpeed());
                    carH.GetComponent<Carmovement>().triggerCarMove(currentTrial.getCarASpeed());
                    carI.GetComponent<Carmovement>().triggerCarMove(currentTrial.getCarASpeed());
                    carJ.GetComponent<Carmovement>().triggerCarMove(currentTrial.getCarASpeed());
                    carK.GetComponent<Carmovement>().triggerCarMove(currentTrial.getCarASpeed());

               


                    // trigger end of trial in X seconds
                    StartCoroutine(triggerTrialEnd());
                }
                break;
            case constantsMain.GAMESTATE.TRIAL_RUNNING:
                saveDataPoint();
                if (Input.GetKeyDown(KeyCode.A)) {

                    // stop the trial
                    currentGameState = constantsMain.GAMESTATE.TRIAL_END;
                    StopAllCoroutines();

                }
                if (carK.transform.position.x > 2f)
                    {
                    currentGameState = constantsMain.GAMESTATE.TRIAL_END;
                    StopAllCoroutines();
                }
                if (player.transform.position.z > 1f)
                {
                    cross = 1;
                }




     

                break;
            case constantsMain.GAMESTATE.TRIAL_END:
                Debug.Log("END TRIAL");
                endTrial();
                break;
            case constantsMain.GAMESTATE.RECORD_DATA_FILE:
                Debug.Log("RECORD_DATA_FILE");
                saveExperimentData.saveDataToFile(currentTrial);
                currentGameState = constantsMain.GAMESTATE.TRIAL_INITIALISE;
                break;
            case constantsMain.GAMESTATE.END_EXPERIMENT:
                Debug.Log("END_EXPERIMENT");
                break;
            default:
                Debug.Log("Unknown state");
                break;
        }

                // load up first experiment trial

                // run trial

                // record data in memory

                // record data to file

                // joystiq control vs. walking

        }

    public void endTrial()
    {
        // stop the car and hide it
        car1.SetActive(false);
        car1.GetComponent<CarMovementB>().stopCar();
        car2.SetActive(false);
        car2.GetComponent<CarMovementB>().stopCar();
        car3.SetActive(false);
        car3.GetComponent<CarMovementB>().stopCar();
        car4.SetActive(false);
        car4.GetComponent<CarMovementB>().stopCar();
        car5.SetActive(false);
        car5.GetComponent<CarMovementB>().stopCar();
        car6.SetActive(false);
        car6.GetComponent<CarMovementB>().stopCar();
        car7.SetActive(false);
        car7.GetComponent<CarMovementB>().stopCar();
        car8.SetActive(false);
        car8.GetComponent<CarMovementB>().stopCar();
        car9.SetActive(false);
        car9.GetComponent<CarMovementB>().stopCar();
        car10.SetActive(false);
        car10.GetComponent<CarMovementB>().stopCar();
        car11.SetActive(false);
        car11.GetComponent<CarMovementB>().stopCar();
        carA.SetActive(false);
        carA.GetComponent<Carmovement>().stopCar();
        carB.SetActive(false);
        carB.GetComponent<Carmovement>().stopCar();
        carC.SetActive(false);
        carC.GetComponent<Carmovement>().stopCar();
        carD.SetActive(false);
        carD.GetComponent<Carmovement>().stopCar();
        carE.SetActive(false);
        carE.GetComponent<Carmovement>().stopCar();
        carF.SetActive(false);
        carF.GetComponent<Carmovement>().stopCar();
        carG.SetActive(false);
        carG.GetComponent<Carmovement>().stopCar();
        carH.SetActive(false);
        carH.GetComponent<Carmovement>().stopCar();
        carI.SetActive(false);
        carI.GetComponent<Carmovement>().stopCar();
        carJ.SetActive(false);
        carJ.GetComponent<Carmovement>().stopCar();
        carK.SetActive(false);
        carK.GetComponent<Carmovement>().stopCar();


        currentGameState = constantsMain.GAMESTATE.RECORD_DATA_FILE;


    }

    // add the rest of the information you want to record

    public void saveDataPoint()
    {
        sampleCounter++;
        dataExperimentSavePoint next = new dataExperimentSavePoint();
        next.setSampleCounter(sampleCounter);
        next.setCar3CurrentPosition(car3.transform.position);
        next.setCar4CurrentPosition(car4.transform.position);
        next.setCarCCurrentPosition(carC.transform.position);
        next.setCarDCurrentPosition(carD.transform.position);
        next.setPlayerPosition(player.transform.position);
        next.setObserverCurrentRotation(headset.transform.localRotation.eulerAngles);

        saveExperimentData.saveDataPoint(next);
    }


    public void initialiseTrial()
    {
        TTC1.SetActive(false);
        TTC2.SetActive(false);
        TTC3.SetActive(false);
        // read in nextTrial details
        currentTrialNumber++;

        // if still more trials to go
        if (currentTrialNumber <= parseSetupFile.experimentDetails.Count-1) {


            // move back to start
            // player.transform.position = new Vector3(0f,1.2f,0f);
            // headset.transform.position = new Vector3(0f, 1.2f, 0f);
            intersense.transform.position = new Vector3(0f, 1.2f, 0f);



            trialInterimText.text = "WAITING (" + (currentTrialNumber+1)  + " of " + parseSetupFile.experimentDetails.Count + ")";
            currentTrial = (experimentDetail)parseSetupFile.experimentDetails[currentTrialNumber];

            sampleCounter = 0;

            carCollision = 0;

            nearMiss = 0;

            // clear for new data
            saveExperimentData.clearData();

            currentGameState = constantsMain.GAMESTATE.TRIAL_WAIT_START;
        }
        else
        {
            trialInterimText.text = "END EXPERIMENT";
            currentGameState = constantsMain.GAMESTATE.END_EXPERIMENT;
            Application.Quit();
        }



        playsound1 = false;
        playsound2 = false;
        playsound3 = false;
        //set traffic number

        Speed = currentTrial.getCarBSpeed();
        Distance = currentTrial.getCarDStartPosition().x;

     

        if (Speed == 20)
        {
            Speed = 8.9408f;
        }
        if (Speed == 30)
        {
            Speed = 13.4112f;
        }
        if (Speed == 40)
        {
            Speed = 17.8816f;
        }



        currentTraffic = currentTrial.getTrafficNumber();

        if (currentTraffic > 1)
        {
            // set cars to be visible
            car1.SetActive(true);
            car2.SetActive(true);
            car3.SetActive(true);
            car4.SetActive(true);
            car5.SetActive(true);
            car6.SetActive(true);
            car7.SetActive(true);
            car8.SetActive(true);
            car9.SetActive(true);
            car10.SetActive(true);
            car11.SetActive(true);
            carA.SetActive(true);
            carB.SetActive(true);
            carC.SetActive(true);
            carD.SetActive(true);
            carE.SetActive(true);
            carF.SetActive(true);
            carG.SetActive(true);
            carH.SetActive(true);
            carI.SetActive(true);
            carJ.SetActive(true);
            carK.SetActive(true);




            // set to start position

            car1.transform.position = currentTrial.getCar1StartPosition();
            car2.transform.position = currentTrial.getCar2StartPosition();
            car3.transform.position = currentTrial.getCar3StartPosition();
            car4.transform.position = currentTrial.getCar4StartPosition();
            car5.transform.position = currentTrial.getCar5StartPosition();
            car6.transform.position = currentTrial.getCar6StartPosition();
            car7.transform.position = currentTrial.getCar7StartPosition();
            car8.transform.position = currentTrial.getCar8StartPosition();
            car9.transform.position = currentTrial.getCar9StartPosition();
            car10.transform.position = currentTrial.getCar10StartPosition();
            car11.transform.position = currentTrial.getCar11StartPosition();
            carA.transform.position = currentTrial.getCarAStartPosition();
            carB.transform.position = currentTrial.getCarBStartPosition();
            carC.transform.position = currentTrial.getCarCStartPosition();
            carD.transform.position = currentTrial.getCarDStartPosition();
            carE.transform.position = currentTrial.getCarEStartPosition();
            carF.transform.position = currentTrial.getCarFStartPosition();
            carG.transform.position = currentTrial.getCarGStartPosition();
            carH.transform.position = currentTrial.getCarHStartPosition();
            carI.transform.position = currentTrial.getCarIStartPosition();
            carJ.transform.position = currentTrial.getCarJStartPosition();
            carK.transform.position = currentTrial.getCarKStartPosition();
        }
        else
        {
            // set cars to be visible


            car1.SetActive(false);
            car2.SetActive(false);
            car3.SetActive(false);
            car4.SetActive(false);
            car5.SetActive(false);
            car6.SetActive(false);
            car7.SetActive(false);
            car8.SetActive(false);
            car9.SetActive(false);
            car10.SetActive(false);
            car11.SetActive(false);
            carA.SetActive(true);
            carB.SetActive(true);
            carC.SetActive(true);
            carD.SetActive(true);
            carE.SetActive(true);
            carF.SetActive(true);
            carG.SetActive(true);
            carH.SetActive(true);
            carI.SetActive(true);
            carJ.SetActive(true);
            carK.SetActive(true);





        }
        Debug.Log(Distance);
        if (Distance == -149.3f)
        {
            Distance = 80;
        }

        if (Distance == -139.3f)
        {
            Distance = 70;
        }


        if (Distance == -129.3f)
        {
            Distance = 60;
        }


        if (Distance == -119.3f)
        {
            Distance = 50;
        }

        if (Distance == -109.3f)
        {
            Distance = 40;
        }


        if (Distance == -99.3f)
        {
            Distance = 30;
        }

        TTC = Distance / Speed;

    }


    IEnumerator triggerTrialEnd()
    {
        yield return new WaitForSeconds(parseSetupFile.TRIAL_RUN_TIME);

        currentGameState = constantsMain.GAMESTATE.TRIAL_END;

    }



}
