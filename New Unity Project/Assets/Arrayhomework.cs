using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrayhomework : MonoBehaviour {
    private string[] person = { "Tom", "Jessica", "Frank", "Sally", "Hank" };
    private string[] adj = { "gentle", "happy", "poopy", "sweaty", "crazy" };
        private string[] verb1 = { "bent", "break", "freeze", "clingy", "burst" };
    private string[] prtOfBody = { "Leg", "Head", "pinky finger", "belly button", "Weiner" };
    private string[]number = { "69", "12", "32", "169", "58"};
        private string[] noun = { "monkeys", "soiled pants", "pee bottle", "poop in a bag", "poop" };
    private string[] adverb = { "repeatedly", "Wildly", "basically", "well", "superb" };
    private string[]  verb2 = { "pooping", "dread", "attack", "bounce", "groan"};
        private string[] pronoun = { "Homies", "Gangsters", "Haters", "developers", "Berny Groupies" };
    private string[] otherPerson = { "nose picking hayley", "Robert who sharts his pants", "Ulga with the mole", "Victor butt smeller", "Crazy Betty" };


    // Use this for initialization
    void Start () {
		


        print (person[Random.Range(0, person.Length)] + " You are extremly " + adj[Random.Range(0, adj.Length)] + " and I " + verb1[Random.Range(0, verb1.Length)] + " you!I want to kiss your " + prtOfBody[Random.Range(0, prtOfBody.Length)] + " " +  number[Random.Range(0, number.Length)] + " times.You make my " + noun[Random.Range(0, noun.Length)] + " burn with desire.When I first saw you, I " + adverb[Random.Range(0, adverb.Length)] + " stared at you and fell in love.Will you " + verb2[Random.Range(0, verb2.Length)] + " out with me ? Don`t let your parents discourage you, " + pronoun[Random.Range(0, pronoun.Length)] + " are just jealous." + " -Yours forever, " + otherPerson[Random.Range(0, otherPerson.Length)]);
	}
	
}
