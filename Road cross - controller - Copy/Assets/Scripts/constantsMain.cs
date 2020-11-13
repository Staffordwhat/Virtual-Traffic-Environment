using UnityEngine;
using System.Collections;

public class constantsMain {

	public enum GAMESTATE
    {
        
        PARSE_CONFIG,
        PARSE_CONFIG_WAIT,
        WAIT_CONFIG,
        TRIAL_INITIALISE,
        WAIT_INPUT,
        TRIAL_WAIT_START,
        TRIAL_START,
        TRIAL_RUNNING,
        TRIAL_END,
        RECORD_DATA_FILE,
        END_EXPERIMENT
    }
    public static string CAR_1_NAME = "car1";
    public static string CAR_2_NAME = "car2";
    public static string CAR_3_NAME = "car3";
    public static string CAR_4_NAME = "car4";
    public static string CAR_5_NAME = "car5";
    public static string CAR_6_NAME = "car6";
    public static string CAR_7_NAME = "car7";
    public static string CAR_8_NAME = "car8";
    public static string CAR_9_NAME = "car9";
    public static string CAR_10_NAME = "car10";
    public static string CAR_11_NAME = "car11";
    public static string CAR_A_NAME = "carA";
    public static string CAR_B_NAME = "carB";
    public static string CAR_C_NAME = "carC";
    public static string CAR_D_NAME = "carD";
    public static string CAR_E_NAME = "carE";
    public static string CAR_F_NAME = "carF";
    public static string CAR_G_NAME = "carG";
    public static string CAR_H_NAME = "carH";
    public static string CAR_I_NAME = "carI";
    public static string CAR_J_NAME = "carJ";
    public static string CAR_K_NAME = "carK";
    public static string PLAYER_NAME = "intersenseCameraController";

    public static string TRIAL_RUN_TIME = "trailRunTime";

    public const string DATE_FORMAT = "yyyy MM dd hh:mm:ss.fff";
    public static float ONE_MPH_IN_METRES_SECOND = -0.44704f;
    public static float ONE_KM_PER_HOUR_IN_METRES_SECOND = 0.27777778f;
}
