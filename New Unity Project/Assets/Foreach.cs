using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foreach : MonoBehaviour {
    public List<string> friends;
    public List<string> dog;
    public List<string> cat;

    // Use this for initialization
    void Start()
    {

        foreach (string friend in friends)
        {
            print(friend);


            switch (friend)
            {
                case "cats":
                    cat.Add(friend);
                    friends.Remove(friend);
                    break;

                case "dogs":
                    dog.Add(friend);
                    friends.Remove(friend);
                    break; }
            



        }
        
            friends.Clear ();
        
        {

        }
        
    }
    }

