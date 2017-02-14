using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElseStatments : MonoBehaviour {
    private int time = 8;

	// Use this for initialization
	void Start () {
        if (time <= 12)
        {
            print("Good Morning my friend!");
        }
        else if(time == 12)
        {
            print("Its Lunch time baby!!");
        }
        else if (time < 18)
        {
            print("Good Afternoon!!!");
        }
        
        

		
	
	
		
	}
}
