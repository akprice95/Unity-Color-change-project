using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ifassignment : MonoBehaviour {
    private int jazz = 96;    //Jazz Score
    private int nuggets = 93;    //Nuggets Score
    private new string name = "Gordan Hayward";
    private bool MVP = true ;

    // Use this for initialization
    void Start()
    {
        //MVP Boolians
        //Lol, I know they dont work in basketball thinking but the idea was to just display which player would be the mvp 
        //depending on if it was true or false
        if (MVP != true)
        {
            print("Emanuel Mudiay is todays MVP");  
        }
        if (MVP == true)
        {
            print("Rudy Gobert is todays MVP");
        } 

        //int displaying game between Utah Jazz, and Denver Nuggets

        if (jazz == nuggets)
        {
            print("The Jazz and the Nuggets Tied at " + ("85 points"));
        } 
        if (jazz != nuggets)
        {
            print("The game was re scheudled due to whether.");
        }
        if (jazz > nuggets)
        {
            print("The jazz won tonight with a score of" + ( jazz + 12 ));
        }
        if (jazz < nuggets)
        {
            print("The Nuggets won tonight with a score of" + (nuggets + 5));
        }
        if (jazz <= nuggets)
        {
            print("The nuggets have the ball with 4 seconds left, if they miss the shot, the jazz and nuggets will go in overtime.");
        }
        if (jazz <= nuggets)
        {
            print("The jazz have the ball with 4 seconds left, if they miss the shot, the jazz and nuggets will go in overtime.");
        }

        //using string to display the playe of the game!
        if (name == "Gordan Hayward") {

            print(name + "is the player of the game");
        }







    }  
}

