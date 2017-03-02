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

