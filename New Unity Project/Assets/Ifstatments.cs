using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ifstatments : MonoBehaviour {
    private int A = 10;
    private int B = 3;
    private new string name = "Hope";
    private bool awake = false;



    /*
     * ==
     * !=
     * <
     * >
     * <=
     * >=
     */


    // Use this for initialization
    void Start() {
        if (awake != true)
        {
            print("wake up!!!!");
            awake = true;

        }

        if (name == "austin")
        {
            print(name);
        }
        if (A == B)
        {
            print("A is equal to B");
        }

        if (A != B)
        {
            print("A is not equal to B");
        }

        if (A < B)
        {
            print("A is less than B");
        }

        if (A > B)
        {
            print("A is greater than B");
        }

        if (A <= B)
        {
            print("A is greater than/equal to B");
        }

        if (A >= B)
        {
            print("A is more than/equal to B");
        }

		
	}
}
