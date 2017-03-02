using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listhomework : MonoBehaviour
{

    public string animal;
    public List<string> zooRoster = new List<string>();


    // Use this for initialization
    void Start()
    {
        zooRoster.Add("monkey");
        zooRoster.Add("Shark");
        zooRoster.Add("Elephant");
        zooRoster.Add("alligator");
        zooRoster.Add("Tarzan");
        zooRoster.Add("Lion");

    }
    public void addAnimal()
    {
        if (zooRoster.Contains(animal) != true)
            if (animal != "")
            {
                if (zooRoster.Contains(animal) != true)
                {
                    zooRoster.Add(animal);
                }




            }
    }

    public void removeAnimal(int listIndex)
    {
        zooRoster.RemoveAt(listIndex);
    }




    
    
    public void clearAnimal()
    {
        zooRoster.Clear();
    }

    public void printAnimals()
    {
        print(zooRoster);
    }
    


}
//In this Assignment I learned about list and how you can set functions with different buttons. My favorite part was applying the functions to each indidual button. I learned that you could have all th functions in the code
//and then take each one individually out of the code to apply them to a button.
