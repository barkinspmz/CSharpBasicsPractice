using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCase : MonoBehaviour
{

    /*
         We're using switch when checking the one variable's condition. Logic:
        
         switch(variable)
         { 
           case X:
               Debug.Log(Do smthg magic!");
           break;
           
           case Y:
               Debug.Log("Do smthg");
           break;
           
           default:
               Debug.Log("I cannot do anythg");
           break;
         }
        
        EXAMPLE WITH variable
        int health = 100;

         switch(health)
         { 
           case 60:
               Debug.Log("You have mid HP");
           break;
           
           case 30:
               Debug.Log("You have low HP");
           break;
           
         }
         
         OTHER EXAMPLE WITH USING DEFAULT. - USAGE OF "DEFAULT "
         DEFAULT HAS SAME FUNCTION WITH ELSE IN - IF-ELSE LOGIC. It checks all cases after that if the cases
         didn't match, it goes to Default section.

         FOR EX:

         string nameOfPlayer = "Tim";

         switch(nameOfPlayer)
         { 
           case "John":
               Debug.Log("Hi John!");
           break;
           
           case "Jessica":
               Debug.Log("Hi Jessica!");
           break;
           default:
               Debug.Log("Hi Tim");
           break;
         }

         OUTPUT : Hi Ti1m
         
         Let's define enum and play with it on Start method
     */
    private enum _Difficulty {Easy, Normal, Difficult };
    _Difficulty currentDifficulty = _Difficulty.Normal;
    void Start()
    {
        Debug.Log("This Start method called from SwitchCase script.");
        switch (currentDifficulty)
        {
            case _Difficulty.Easy:
                Debug.Log("The gane will be on easy mode");
                break;
            case _Difficulty.Normal:
                Debug.Log("The gane will be on normal mode");
                break;
            case _Difficulty.Difficult:
                Debug.Log("The gane will be on difficult mode");
                break;

            default:
                Debug.Log("ERROR: There is no any difficulty!");
                break;
        }
    }

    
    void Update()
    {
        
    }
}
