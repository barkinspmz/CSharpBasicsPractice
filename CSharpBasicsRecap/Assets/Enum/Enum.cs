using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enum : MonoBehaviour
{
    /*
     
    -ENUM 

    An enum is a special "class" that represents a group of constants (unchangeable/read-only variables). (W3SCHOOL DEFINITION).

    Syntax:

    [A.c M] [enum] [name of enum]     [datas in enum]
    public enum Difficulty { Easy, Medium, Difficulty, Expert}
    public Difficulty currentDif = Difficulty.Medium;

    It allow us more readable code. We could do it like this too. Let's see why it is more readable.

    int difficulty = 1;
    
     switch (difficulty)
        {
            case 0:
                    //Easy Mode Codes
                break;
            case 1:
                    //Medium Mode Codes
                break;
            case 2:
                    //Difficult Mode Codes
                break;
            case 3:
                    //Expert Mode Codes
                break;
            default:
                break;
        }

    public enum Difficulty { Easy, Medium, Difficulty, Expert}
    public Difficulty currentDif = Difficulty.Medium;

     switch (currentDif)
        {
            case Difficulty.Easy:
                break;
            case Difficulty.Medium:
                break;
            case Difficulty.Difficulty:
                break;
            case Difficulty.Expert:
                break;
            default:
                break;
        }

    As you can see, it is much more readable. You might forget what is 0,1,2,3 but you cannot while you make it more daily-life reading way.
    */

    public enum Difficulty { Easy, Medium, Difficulty, Expert }
    public Difficulty currentDif = Difficulty.Medium;
    void Start()
    {
        switch (currentDif)
        {
            case Difficulty.Easy:
                Debug.Log("Easy mode");
                break;
            case Difficulty.Medium:
                Debug.Log("Medium mode");
                break;
            case Difficulty.Difficulty:
                Debug.Log("Difficult mode");
                break;
            case Difficulty.Expert:
                Debug.Log("Expert mode");
                break;
            default:
                Debug.Log("There is no any difficulty level that you chose!");
                break;
        }
    }

}

