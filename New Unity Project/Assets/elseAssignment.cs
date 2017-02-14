using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elseAssignment : MonoBehaviour {
    private int degree = 52;
    private bool snow = true;
    private int movieTuesday = 5;
    private bool popcorn = false;
    private string student = "john";

    // Use this for initialization
    void Start() {
        if (degree <= 55)
        {
            //so if the degree is less than 55 it will display the following
            print("Put on a jacket you crazy");
        }
        else if (degree == 55)
        {
            //if it equals 55 it will tell the user the following
            print("Put on a light jacket!!");
        }
        else if (degree >= 55)
        {
            //if its above 55 degrees is will propt the user to do the following
            print("Shorts a teeshirt baby!!!");
        }


        //if the statment is true and it snowed that day
        //it will  prompt the user to go skiing
        if (snow == true)
        {
            print("Its time to go skiing");
        }
        //if the statment is false, it will prompt the user
        //to pray to the snow gods
        else
        {
            print("Pray to the snow gods today");
        }

        //This section will tell the user to go to the movies on movie tuesday because its discounted
        if (movieTuesday <= 5)
        {
            print("Its movie tuesday!! Get to the movies now!!!");
        }
        else if (movieTuesday >= 5)
        {
            print("It is too expensive to go to the movies today...Save your money!");
        }
        else if (movieTuesday > 10)
        {
            print("This movie is a rip off, dont be a part of the system bro");
        }

        if (popcorn == true)
        {
            print("get some butter for that yummy popcorn");
        }
        else
        {
            print("You will be starving the whole movie...you might die");
        }

        //this if/else statment would keep guessing names until it got the name right
        if (student == "mary")
        {
            //if the name is mary it will welcome her
            print("Welcome to class mary");
        }
        else if (student == "tom")
        {
            //if the name is Tom it will welcome him
            print("Welcome to class tom");
        }
        else if (student == "john")
        {
            //if the name is John it will welcome him and tell him he is the favorite
            print("Welcome to class john, your my favorite student");
        }




    }
}
