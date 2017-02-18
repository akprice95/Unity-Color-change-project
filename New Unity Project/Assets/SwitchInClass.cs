using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchInClass : MonoBehaviour {
    private int time = 10;

	// Use this for initialization
	void Start () {
        //create switch statment for time of day
        switch (time)
        {
            case 9:
                print("Good Morning homie!!!!");
                print("Its mostly cold outside today");
                break;
                case 12:
                print("Good Afternon");
                print("Birds flyin high you know how I feel");
                break;

            case 18:
                print("Its time to go home");
                break;
            default:
                print("Get back to work");
                break;
        }
        
       
    	
	}
		
	
}
