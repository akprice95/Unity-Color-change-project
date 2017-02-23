using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whileLoopInClass : MonoBehaviour
{
    public int bottles = 0;
    private bool gameOver = true;
    public int maxBottles = 10;
    // Use this for initialization
    void Start()
    {
        /*  while (bottles < 10)
          {
              print(bottles + "bottles of root beer on the wall. ");
              bottles = bottles + 2;
          }
          print("all done"); */

        while (gameOver == true)
        {
            print(bottles + " bottles of rootbeer on the wall. ");
            bottles++;
            if (bottles == maxBottles)
            {
                gameOver = false;
            }


        }
    }
}
