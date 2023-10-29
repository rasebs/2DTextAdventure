using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int maxNumber = 1000;
    int minNumber = 1;
    int guess = 500;
    // Start is called before the first frame update
    private void Start()
    {
            

        // The game messages
        Debug.Log("Welcome to the number wizard !! Happy to have you ! ");
        Debug.Log("Pick a number, don't tell me what it is... is it " + guess);
        Debug.Log("The max number is :" + maxNumber);
        Debug.Log("The min number is :" + minNumber);
        maxNumber = maxNumber + 1;
    }

    // Update is called once per frame
     void Update()
    {
        //check if Up key is pressed


        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Computer: No you're too low, try guess up");
            Debug.Log("Player: Okay I am lesser than the actual so I am gonna go for ...");
            minNumber = guess;
            UpdateGuess();
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Computer: No you're too high, try guess down");
            Debug.Log("Player: Okay I am higher than the actual so I a  m gonna go for ...");
            maxNumber = guess;
            UpdateGuess();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I have finished the game !!! ");
        }

        // account for three cases
        if (guess ==1 || guess == 1000 || minNumber == maxNumber)
        {
            ResetGuess();
        }


    }

    private void UpdateGuess()
    {
        Debug.Log(guess);
        guess = (minNumber + maxNumber) / 2;
        Debug.Log("Is it the number " + guess);
    }

    private void ResetGuess()
    {
        guess = 500;
        minNumber = 1;
        maxNumber = 1000;
    }   
}