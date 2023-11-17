using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElseLogic : MonoBehaviour
{
    /* In game development process, as game developer, we use the if-else logic
       lots of time. To understand if-else logic clearly, we need to learn body of default
       if-else logic first.
       
       if(CONDITION)
       {
          //If the condition is true, the code lines in there will executed.
       }
       else 
       {
          //If the condition is false, the code lines in there will executed. 
          //Using ELSE is not required thing all the time.
       }

       Let's see with example. First, ask yourself that is 5 > 8 in normal math?
       Your answer should be NO, IT'S NOT! In programming language, we call it FALSE.
       5>8 was CONDITION. Let's see what happens when we apply it if-else logic.

       if(5>8) IS 5 HIGHER THAN 8? NO! OUR CONDITION WILL RETURN FALSE.
       {
           If the condition return true, these code lines will executed.
           For our condition, it is returning false now so there will not executed.
       }

       else
       {
           The condition has returned FALSE, the line of codes in there will executed so
           let's print out that this condition is false.
           Debug.Log("This condition is FALSE!");
       }

       LET'S PRACTICE MORE.
    */
    void Start()
    {
        Debug.Log("This method called from IfElseLogic class.");

        //FIRST IF - ELSE CONDITION
        if (6>9) //Is 6 higher than 9? FALSE!!!! 
        {
            //CONDITION TRUE AREA
        }
        else
        {
            //CONDITION FALSE AREA
            Debug.Log("FIRST IF-ELSE CONDITION IS FALSE!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
