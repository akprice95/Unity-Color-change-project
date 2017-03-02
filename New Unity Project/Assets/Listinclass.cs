using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listinclass : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("------------");
        CountToTen();
        print("------------");
        CountToTen();
        print("------------");
        CountToTen();
        
    }

    void CountToTen()
    {
        int i = 1;
        while (i <= 10)
        {
            print(i);
            i++;
        }
        print ("Congrats! You counted to 10!");
            

    }

}
