using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour {
    private int A = 3;
    private int B = 8;
    private int C = -4;
    private int D = -2;




    // Use this for initialization
    void Start () {
        if (A == B || C < D) {
            print("Hello world");

        }
        if (B > C && D > C || D == 0)
        {
            print("goodbye world");
        }
        
	}
	
}
