using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript3 : MonoBehaviour {
    float[] scores = { 95f, 58f, 73f, 22f, 150f };


    // Use this for initialization
    void Start()
    {
        print (Average(scores));
    }





        float addTogether(float group1, float group2)
        {
            float totalgroup;

            totalgroup = group1 + group2;

            return totalgroup;
        }

    float Average(float[] scores)
    {
        float sum = 0;
        float mean;

        foreach(float thescore in scores)
        {
            sum += thescore;
            sum = sum + thescore;
        }

        mean = sum / scores.Length;
        return mean;
    }
    
        
    
}
