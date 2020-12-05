using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int high, low, myGuess, totalGuesses = 0;
    bool complete = false;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }
    void StartGame()
    {
        low = 1;
        high = 1000;
        Debug.Log("Namaste, Welcome to Number Wizard");
        Debug.Log("Want to see a magic trick???");
        Debug.Log("Pick a number between " + low + " and " + high + ", keep quiet about it...");
        Debug.Log("Play till the end to see the magic");

        myGuess = (low + high) / 2;
        Debug.Log("I will start my guesses now and tell me if I am correct...");
        Debug.Log("Tell me if your no. is lower or higher than " + myGuess);
        Debug.Log("Push up = Higher, Push Down = Lower, Push Enter = Correct");
    }
    void nextGuess()
    {
        myGuess = (low + high) / 2;
        Debug.Log("Tell me if your no. is lower or higher than " + myGuess);
    }
    // Update is called once per frame
    void Update()
    {
        if (complete == false)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                low = myGuess;
                nextGuess();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                high = myGuess;
                nextGuess();
            }
            else if (Input.GetKeyDown(KeyCode.Return))
            {
                totalGuesses++;
                complete = true;
                Debug.Log("Hooray I guessed it... ");
                Debug.Log("So your number is " + myGuess);
                Debug.Log("Buttttt I wont be able to tell the trick :p:p:p");
                Debug.Log("Press Esc. to try your luck at catching my trick :p");
                Debug.Log("BTW no one has figured the trick out yet after " + totalGuesses + " turns");
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                complete = false;
                StartGame();
            }
        }
    }
}
