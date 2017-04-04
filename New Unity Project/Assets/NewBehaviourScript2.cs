using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NewBehaviourScript2 : MonoBehaviour {

    // Use this for initialization
    void Start() {


    }
    public void StartTime()
    {
        string greeting;
        int hour = DateTime.Now.Hour;

        if (hour < 21)
            greeting = "Good morning";
        else if (hour < 17)
            greeting = "Good afternoon";
        else
            greeting = "Good evening";

        print(string.Format("{0}, the current time is {1}.", greeting, DateTime.Now.ToLongTimeString()));
	}
    public void CurrentDate()
    {
        print(DateTime.Now.ToLongDateString());
    }
	
}
