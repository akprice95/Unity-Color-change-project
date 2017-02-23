using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whileLoopAssignment : MonoBehaviour
{

    private int minValue = -10;
    private int maxValue = 10;
    private int randomNum ;
    private int counter = 0;
    private int secretNum = 4;
    // Use this for initialization
    void Start()
    {

        while (randomNum != secretNum)
        {
            counter++;
            randomNum = Random.Range(minValue, maxValue);
            secretNum = 5;
            if (randomNum == secretNum)
            {

                print(" Your Secret Number is " + secretNum);
                print(counter);
                break;
            }




        }
    }
}

		
	
	
	
		


