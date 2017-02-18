using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchAssignment : MonoBehaviour {
    private int work = 1800;
    private string animal = "Monkey";
    private string phrase;
    private bool exist = true;
    private int speed = 90;
    private bool answer = true;
    private string apple = "apple";
    private int weather = 85;


    // Use this for initialization
    void Start () {
        switch (work)
        {
            case 900:
                print("Wake up!!, you have work in a hour!!");
                print("Its mostly cold outside today, so grab a light jacket");
                break;
            case 1200:
                print("Lunchtime boi!!, Grab a sandwhich and head to the break room");
                print("looks like its pastrami today");
                break;

            case 1800:
                print("Its time to go home, clock out and party!");
                break;
            default:
                print("what time is it? Time for you to stop watching the clock");
                break;
        }

        //this switch will tell the user to either slow down or speed up on the freeway

        switch (speed){
            case (65):
                phrase = "your going too slow, speed up to go the speed limit";
                break;
            case (75):
                phrase = "You're going the perfect speed limit";
                phrase = "No tickets for you";
                break;
            case (80):
                phrase = "You're going a litte too fast. Slow down or you may get a ticket";
                break;
            case (85):
                phrase = "You're speeding and most likley will get a ticket";
                break;
            default:
                answer = false;
                break;
        }
        if (answer == true)
        {
            print(phrase + " im supprised you have your license ");
        }
        else
        {
            print(speed + " Mph does not exist...your either going to fast or too slow");
        }




           //shows the actions of animals
    
        switch (animal)
        {
            case "giraffe":
                phrase = "clack clack calck";
                break;
            case "penguin":
                phrase = "slap slap slide";
                break;
            case "Lion":
                phrase = "run run chew";
                break;
            case "fox":
                phrase = "sneak run pounce";
                break;
            default:
                exist = false;
                break;
        }
        if (exist == true)
        {
            print("A " + animal + " does \"" + phrase + "\".");
        }
        else
        {
            print(animal + " does not exist. ");
        }


        //eating healthy choices  app

        switch (apple)
        {
            case "apple":
                print("A apple a day keeps the doctor away");
                break;
            case "Ramen":
                print("Studies show that you will die from eating this");
                break;
            case "burrito":
                print("Yummy, but possible diahrea later");
                break;
            case "Banana":
                print("Healthy choice!");
                break;
            case "Nails":
                print("Chewing your nails is a bad habit you know!");
                break;
        }
        switch (weather)
        {
            case 65:
                print("Its about room temp. Jeans and t shirt will do for today");
                print("I do see clouds thought so prepare for rain");
                break;
            case 45:
                print("ITS FREEZING");
                print("Wear 10 layers of clothing");
                break;

            case 75:
                print("Its perfect weather!! Go get a tan outside and enjoy the weather");
                break;
            case 85:
                print("Its hot out. Go streaking or sweat to death...its your choice");
                break;
            default:
                print("Get back to work");
                break;
        }


     }
}
