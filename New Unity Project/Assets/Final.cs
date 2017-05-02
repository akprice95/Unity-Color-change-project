using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class Final : MonoBehaviour {
    int hour = DateTime.Now.Hour;
    public string Aaron;
    public float addition;
    public float subtraction;
    public float multiply;
    public float divide;
    public string homies;
    public List<int> daHomies = new List<int>();
    public int num1;
    public int num2;
    public bool inch;
    public int train1;
    public int train2;
    public int time;
    public float distance1;
    public float distance2;
    public float distanceTogether;

    // Use this for initialization
    void Start() {


    }


    public void hello()
    {
        //function for #1
        print("Hello Aaron its " + hour);
    }

    //function for #2
    public void math(int num1, int num2)
    {

        //add
        addition = num1 + num2;

        print(addition);

        //subtract
        subtraction = num1 - num2;

        print(subtraction);

        //multiply
        multiply = num1 * num2;

        print(multiply);
        
        //divide
        divide = num1 + num2;

        print(divide);

    }
     //function for #3
    public void friends()
    {
        daHomies.Add(52);
        daHomies.Add(9);
        daHomies.Add(23);
        daHomies.Add(12);
        daHomies.Add(103);
        daHomies.Add(10);
        daHomies.Add(5);
       double daAverage = daHomies.Average();

        print("The average of your List of numbers is " + daAverage);
    }

    public void converter()
    {

        double inc = 12.75; // e.g.

        double feet = Math.Floor(inc);
        double inches = (inc - feet) * 12.0;
    }


    //function for #4
    public void InchToFeet(bool v)
    {
        if (inch == true)
        {


            double inc = 12;

            double feet = 2;
            double inches = (inc * feet);


            print("and the conversion is..." + inches + " inches");

        }
        if (inch == false)
        {
            double inc = 12;

            double feet = 2;
            double inches = (feet * inc);


            print("and the conversion is..." + feet + " Feet");
        }
    }

        public void train()
    {
        distance1 = train1 * time;

        distance2 = train2 * time;

        distanceTogether = distance1 + distance2;

        print("The trains are " + distanceTogether +" apart");
    }
    
	
}
