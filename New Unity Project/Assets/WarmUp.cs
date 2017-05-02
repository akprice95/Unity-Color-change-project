using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarmUp : MonoBehaviour {
    
    public List<string> randomNum = new List<string>();


    private string[] names = { "Joe", "Tanner", "Clayton", "Talon", "Parker" };
    private string[] Color = { "Blue", "Red", "Black", "orange", "Yellow" };

	// Use this for initialization
	void Start () {
        Friends(1, 2, 3);
        addNumber(10);


        //This a for loop that takes the arrays above and matches up number of names, and colors starting from 0 to 4 with one method
        for(int i = 0; i < names.Length; i++){
            print((names[i] + "'s favorite Color is " + Color[i]));
            }
		
	}
    // using floats to add total friends together.
    public void Friends(float friendGroup1, float friendGroup2, float friendGroup3)
    {
        float totalFriends;

        totalFriends = friendGroup1 * friendGroup2 * friendGroup3;
        // the{0} is calling the totalFriends. If there were more after the "" there would be a different number such as {1}
        print (string.Format("Your total ammount of friends are {0}", totalFriends) ); 

    }

    public void addNumber(int totalNumbers)
    {
      List<string> randomNum = new List<string>();


     /*  for ( int i=0; i  < totalNumbers; i++)
        {
          int number = (Random.Range(0, 100));

            number.Add(randomNum);
        } */

    }
	
}
