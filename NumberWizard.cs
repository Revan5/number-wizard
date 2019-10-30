using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

   
 void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a number");
        Debug.Log("The highest number is : " + max);
        Debug.Log("The lowest number is : " + min);
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Press Up = Higher , Press Down = Lower , Press Enter = Correct");
        max = max + 1;
    }
