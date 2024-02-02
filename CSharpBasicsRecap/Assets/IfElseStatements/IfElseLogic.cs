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
       THIS IS BASIC LOGIC OF IF-ELSE

       LET'S PRACTICE MORE. 
       
       !For checking equality in condition, we are using "==" 'equals to' operator.!
       For EX:
       int theNumber = 5; we defined int type variable named theNumber as 5.
       int secondNumber = 6; we definet int type variable named secondNumber as 6;
       
       if(theNumber == secondNumber) //CHECKING THIS CONDITION FIRST. IS 5 EQUALS TO 6? NO.
       {
           We know that conditions return false. So this line of codes will not executed.
           Debug.Log("This condition is TRUE!");
       }
       else 
       {
            If condition is FALSE. It goes directly to the else statement. These line of code will executed.
            Debug.Log("This condition is FALSE!");
       }

       Let's see more example in Start method.
    */

    enum Difficulties { Easy, Normal, Hard };
    Difficulties difficulties;
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

        int a = 14;
        int b = 12;
        if (a > b)
        {
            Debug.Log("SECOND IF - ELSE CONDITION RETURNS TRUE");
        }
        else
        {
            //There will be not executed. Because 14 > 12
        }

        bool isAlive = true;
        if(isAlive) //If the isAlive variable returns true, it means player is alive if not player is dead.
        {
            Debug.Log("The player is alive.");
        }
        else
        {
            Debug.Log("The player is dead");
        }

        // " ! " OPERATOR USAGE - IT MEANS IT IS NOT TRUE
        bool canMove = false; 
        if (!canMove) //Sentence version of this condition. - If canMove is not true. Same with if(canMove == false)
        {
            Debug.Log("Player cannot move");
        }

        //USAGE OF || 'OR' - && 'AND' 
        if (canMove && isAlive)//IF THE PLAYER canMove IS TRUE AND isAlive IS TRUE AT THE SAME TIME
        {
            //To execute the line of codes in here, the both condition must return true.
            Debug.Log("Both variable returns true");
        }

        if (canMove || isAlive) // IF THE canMove IS TRUE OR isAlive IS TRUE?
        {
            //To execute the line of codes in here, one of the condition needs return true is enough. 
            //if one of them returns true, the codes in here will executed.
            Debug.Log("One of the condition is true!");
        }

        //LET'S SEE HOW TO USE IF-ELSE IF-ELSE LOGIC
        /*
           WORKFLOW
           
           LOOKING FOR TRUE CONDITION UNTIL FIND IT 
           if(condition) 1. CHECKING FIRST IF CONDITION. IF IT IS NOT TRUE, IT GOES TO ELSE IF
           { 
               Debug.Log("Condition is TRUE in first check");
           }

           else if(secondCondition) 2.CHECKING FOR THIS CONDITION. IF IT IS TRUE, THE CODES WILL EXECUTED BUT IF IT NOT TRUE AND
           IF THERE IS ELSE STATEMENT, IT WILL GO INTO THE ELSE STATEMENT.
           {
                Debug.Log("Condition is TRUE in second check");
           }

           else 3. IF BOTH THOSE CONDITIONS ARE FALSE, THIS LINE OF CODES WILL EXECUTED.
           {
                Debug.Log("All those conditions were false!);
           }

         LET'S PRACTICE!
         */
        if (Input.GetKeyDown(KeyCode.Q))
        {
            difficulties = Difficulties.Easy;
        }
        else if(Input.GetKeyDown(KeyCode.R))
        {
            difficulties = Difficulties.Hard;
        }
        else
        {
            difficulties = Difficulties.Normal;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
