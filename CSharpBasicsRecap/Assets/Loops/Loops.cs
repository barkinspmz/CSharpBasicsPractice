using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    /*
         LOOPS -
              
             Loops are the things that allow us to do some line of codes multiple times until 
            the declared condition is true. When the condition turn into false, the loop will break.

            There 4 type of loop. 
            - While Loop
            - DoWhile Loop
            - For Loop
            - Foreach Loop

            All of the loop provide execute code until the condition is true. Imagine that you want to print out 1 to 100;
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            .
            .
            .
            .
            Console.WriteLine("100");

            There are 100 Console.WriteLines. It looks dirty and against-performance way.
            
            With using Loops, you can write it like this.  - While Loop I will use.
            int number = 1;
            while(number<=100)
            {
                Console.WriteLine(number);
                number++;
            }

            ### OUTPUT WILL THE SAME WITH USING 100 TIMES CONSOLE.WRITELINE. It is more clean, more performance friendly way.

           LET'S INTRODUCE LOOPS ONE BY ONE. STARTING WITH WHILE LOOP.
         

           1- WHILE LOOP:

                       Syntax: while(condition) 1. If the condition is true, it will execute lines of codes in there.
                               {
                                   //codes that will executed for each time) 
                                   
                               } //2. After finish execute code, it goes to first step; checking condition is true or not.
                       
                       EXMP: 
                              int a = 0;
                              while(a < 5)
                              {
                                  Console.Write(a);
                                  a++;
                              }
                      OUTPUT: 0 1 2 3 4 

         When using While Loop, take care to make it infinite loop.
         
         For Example: 
                      int i = 0;
                      while(i < 10)
                      {
                          Console.WriteLine(i);
                      }
                      int i will stay at 0 all the time. 0 less than 10 so the condition always return true. It means, it is infinite loop.
                      It causes performance issues. Take care to handle your loop's condition.
         
         2- DO WHILE LOOP

                    Syntax: It same with while loop. Only different thing is that it execute code for once even the condition is true or not. After it,
                    it start the check condition.

                    int i = 0;

                      do  //It execute code without checking condition once.
                      {
                          Console.WriteLine(i); //Executing code.
                      } while((i < 10); //If the condition return true, the loop continue.

         3 - FOR LOOP

                    Syntax: It is most common loop. In brackets, it has declaration, checking condition and increment or decrement section.

                    for(int i = 0; i < 10 ; i++)
                    {
                        //lines of code that will executed.
                    }
                    
                    (int i = 0 // Declaration Phase; i < 10 //Checking condition phase, if it returns false, loop will break. It is same with other loops.; i++ Increment or Decrement for each turn);
                     
                    Example: Let's print out all the number 1 to 10;
     
                    for(int i = 1; i<=10; i++)
                    {
                        Console.Write(i);
                    }
                
                    OUTPUT: 1 2 3 4 5 6 7 8 9 10
                    
                    Flow of For loop above. 
                    FIRST TURN: 
                    int i = 1; 
                    is 1 less equal than 10? YES! Then execute code. Console.Write(i)
                    is executed code? YES! Do I need increment or decrement? INCREMENT because it says i++; on Right side. Increment 1 to i.
                    
                    SECOND TURN:
                    int i = 2; now because it is incremented.
                    is 2 less equal than 10? YES! Then execute code. Console.Write(i)
                    is executed code? YES! Do I need increment or decrement? INCREMENT because it says i++; on Right side. Increment 1 to i.
           
                    THIRD TURN: 
                    int i = 3; now because it is incremented.
                    is 3 less equal than 10? YES! Then execute code. Console.Write(i)
                    is executed code? YES! Do I need increment or decrement? INCREMENT because it says i++; on Right side. Increment 1 to i.
                    .
                    .
                    .
                    .
                    11TH TURN:
                    int i = 11; now because it is incremented.
                    is 11 less equal than 10? NO! Then DO NOT execute code. BREAK THE LOOP.


         4- FOREACH LOOP 

                    Syntax: This loop only use in Arrays/Lists.

                    For Example; 
                     
                    foreach (var item in [Array/List Name])
                    {  
                         Execute code;
                    }

                    Practice: 
                    I will make a program where the user will enter username and the system will
                    inform that the given username in their data.

                    string[] userNames;
                    names[0] = "Jonathan";
                    names[1] = "Barkin";
                    names[2] = "Tim"; 

                    Console.Write("Enter your username: ");
                    string userNameInput = Console.ReadLine();
           
                    foreach(string userName in userNames)
                    {
                        if(username == userNameInput)
                        Console.WriteLine(userNameInput + " username in our data!");
                    }
           

           General Info : BREAK & CONTINUE KEYWORDS
           Break: Breaks the loop.
           Continue: Continue the current loop turn.

           Exmp: 
           int i = 0;
           while(i<10)
           {
               
              i++;
              if(i == 5) continue; //It will pass the printin 5 to screen.
              if(i == 8) break; //When i equals to 8, the loop will break, and then stop.
              Console.WriteLine(i);
           }


           THAT'S ALL FOR LOOPS. LET'S PRACTICE IT ON START METHOD.
     */

    void Start()
    {
        Debug.Log("This Start Method called from Loops script.");

        //Q1 - Print 1 to 5
        int maxNumber = 5;

        for (int i = 1; i <= maxNumber; i++)
        {
            Debug.Log(i);
        }

        //Q2 - Print all the names in names array.
        string[] names = { "Barkýn", "Jonathan", "Haaland" };
        foreach (string name in names) { Debug.Log(name); }

        /*Q3 - Print out this
                  
            *
            * *
            * * *
            * * * *
         */

        for (int i = 1; i <= 4; i++)
        {
            for (int Z = 0; Z < i ; Z++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
                  
    }
}
