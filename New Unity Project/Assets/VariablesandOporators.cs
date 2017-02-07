using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesandOporators : MonoBehaviour {
    //define pi, and radius
    private float pi = 3.14159265359f;
    private float radius = 2.5f;

    //create variables length and width 
    private float length = 2;
    private float width = 5;

    //base and height variables
    private float tBase = 5;
    private float height = 10;

	// Use this for initialization
	void Start () {
        //Sphere

        //Find the diameter of the circle
        float diameter = 2 * radius;
        print ("The Diameter of the circle with radius " + radius + " is " + diameter);
       
        //Find the Circumference
        float circumference = 2 * pi * radius;
        print("The Circumference of the circle with radius " + radius + " is " + circumference);
        
        //Find the area of a circle
        float area = pi * (radius * radius);
        //diplay results
        print("The area of the circle with radius " + radius + " is " + area);

        //Find the volume of a sphere
        float volume = (4 / 3) * pi * radius * radius * radius;
        print("The volume of the circle with radius " + radius + " is " + volume);

       //Rectangle
        
        //Find the perimeter of a rectangle
        float perimeter = 2 * (length + width);
        print("The perimeter of the rectangle is " + perimeter);

        //Find the area of a rectangle
        float recArea = width * length;
        print("The area of the rectangle is " + recArea);

        //Triangle

        float triArea = (height * tBase) / 2;
        print("The area of the Triangle is " + triArea);




    }
		
}

