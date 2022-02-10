using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int min, max, guess, count = 0;
    // Start is called before the first frame update
    void Start()
    {
        print("Welcome to Number Wizard!");
        StartGame();
    }

    void StartGame()
    {
        min = 1;
        max = 1000;
        guess = (min + max) / 2;

        print("You have to think of a number in your mind but you don't have to tell it to me!");

        print("The minimum number you can think of is " + min);
        print("The maximum number you can think of is " + max);
        max++;

        print("Higher or lower than " + guess);
        print("Up = Higher, Down = Lower, Enter/Return = Equal");
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            count++;
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            count++;
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            count++;
            print("Number is guessed! I won by gueesing it " + count + " time(s)!");
            count = 0;
            StartGame();
        }
    }
        
    

    void NextGuess()
    {
        guess = (max + min) / 2;

        print("Higher or lower than " + guess);
        print("Up = Higher, Down = Lower, Enter/Return = Equal");

    }
}
