using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchInClass2 : MonoBehaviour {
    private string animal = "Monkey";
    private string phrase;
    private bool exist = true;

	// Use this for initialization
	void Start () {
        switch (animal)
        {
            case "giraffe":
                phrase = "Mooooo";
                break;
            case "penguin":
                phrase = "Morgan Freeman";
                break;
            case "Lion":
                phrase = "roar";
                break;
            case "fox":
                phrase = "lsjfdlsakjflksadjdfl";
                break;
            default:
                exist = false;
                break;
        }
        if (exist == true)
        {
            print("A " + animal + " say \"" + phrase + "\".");
        }
        else
        {
            print(animal + " does not exist. ");
        }

        
		
	
		
	}
}
