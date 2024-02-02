using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooleanExpression : MonoBehaviour
{
    /*
         Bool is a data type that stores only TRUE or FALSE.
         There are useful and efficient usage of booleans on game development.
         For example isPlayerAlive? isGameEnded? isQuestDone? isInventoryFull?

         Let's learn the usage of booleans on C#.

         Debug.Log(10>4) - Is 10 higher than 4? YES! So it will return TRUE! 
         OUTPUT : TRUE
     
         Debug.Log(5<12) - Is 5 less than 12? NO! So it will return FALSE!
         OUTPUT : FALSE

         Debug.Log(120 < 62) - Is 120 less than 60? NO! So it will return FALSE!
         OUTPUT : FALSE

         Debug.Log(10>4) - Is 10 higher than 4? YES! So it will return TRUE! 
         OUTPUT : TRUE

         Debug.Log("barkin" == "john") - Is barkin equals to john? ABSOULATELY NOT! Return FALSE!
         OUTPUT : FALSE

         if(4 > 5) - Is 4 higher than 5 ? No. The code will not execude in this statement.
         {
               Debug.Log("Hello world!");
         }
         OUTPUT : NOTHING

         if(11 > 6) - Is 11 higher than 6 ? YES!. The code will execude in this statement.
         {
               Debug.Log("Hello world!");
         }
         OUTPUT : Hello world!
          
         DIFFERENT EXAMPLE: WE WILL DECLARE BOOLEAN VARIABLE WHICH IS EQUAL TO TRUE
         bool isPlayerAlive = true;
         Debug.Log(isPlayerAlive) - IsPlayerAlive? As we declared, yes it is so it will return TRUE!
         OUTPUT: TRUE.
         
    */


    // CREATE A MINI GAME!!

    //Imagine that we're creating idle game. Player can get some damages when some actions happened.
    //Player will have 5 HP at start, when Player hit the Space Key, player will lose 1 HP.
    //When player HP equals to 0, it means that player is dead. Our isPlayerAlive variable will turn into false.
    //When isPlayerAlive variable turn to false, YOU HAVE DIED text will appear on the Debug Tab.

    //We have declared isPlayerAlive boolean variable. When the game start player will alive.
    bool isPlayerAlive = true;

    //Let's declare player's health point variable which equals to 5.
    int playersHealth = 5;
    void Start()
    {
        Debug.Log($"These codes iniated by {this.gameObject.name}'s Start method.");
        if (11>6)
        {
            Debug.Log("Hello John!");
        }
        //OUTPUT: Hello Jessica

        if (7<14)
        {
            Debug.Log("Hello Jessica!");
        }
        //OUTPUT: Hello Jessica

        if (8>15)
        {
            Debug.Log("Hi!");
        }
        //OUTPUT: NOTHING BECAUSE THE CODE WILL NOT EXECUTED.

        Debug.Log("-------------------");
    }

    
    void Update()
    {
        //If the player HIT SPACE KEY.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Our player's health will decrease one.
            playersHealth--;

            //We will check that player's health is equal to 0 or not.
            if (playersHealth <= 0)
            {
                //If player's health is less equal than 0, we will turn our boolean variable to false.
                //It means that player doesn't have any health point to play game so player is dead.
                isPlayerAlive = false;
            }

            //If the isPlayerAlive variable is true which means player keep alive
            if (isPlayerAlive)
            {
                Debug.Log("The player is alive. Player's current HP: " + playersHealth);
            }
            //If the isPlayerAlive variable is false which means player is dead.
            //PLAYER IS DEAD TEXT WILL APPEAR!
            else
            {
                Debug.Log("PLAYER IS DEAD!");
            }
        }
    }
}
