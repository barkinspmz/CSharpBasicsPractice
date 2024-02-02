using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Operators : MonoBehaviour
{
    /*
           It is used to perform operations on variables.
           Basic math operators do exact same function in real life on C#.
            
           The operators in C#:
           
           +  = Addition
           - = Subtraction
           * = Multiplication
           / = Division
           % = Modulus
           ++ = Increment one
           -- = Decrement one

           || = OR
           && = AND

           == = Equal
           != = Not equal
           
           Other shortcut operators: 
           5 += 10 it means that 5 = 5 + 10. It will be now 15.
           8 += 12 it means that 8 = 8 + 12. It will be now 20.
           
           20 -= 10; it means that 20 = 20-10; It will be now 10.
           12 -= 5; it means that 12 = 12-5; It will be now 7.
           
           Let's practice on Start method.
     */
    void Start()
    {
        Debug.Log("This function called from Operators class.");
        int firstNumber = 15;
        int secondNumber = 7;
        int sum = firstNumber + secondNumber;
        int difference = firstNumber - secondNumber;
        int multiply = firstNumber * secondNumber;
        int divide = firstNumber / secondNumber;
        int modul = firstNumber % secondNumber;

        //Increment one the firstNumber variable data.
        firstNumber++;

        //Decrement one the firstNumber variable data.
        firstNumber--;

        //LET'S SEE WHAT HAPPENS. YOU CAN CHECK THE CONSEQUENCES OF THIS OPERATORS ON DEBUG TAB
        //WHEN YOU START THE GAME.

        Debug.Log($"Summary of {firstNumber} + {secondNumber} = {sum}");
        Debug.Log($"Difference of {firstNumber} - {secondNumber} = {difference}");
        Debug.Log($"Multiply of {firstNumber} * {secondNumber} = {multiply}");
        Debug.Log($"Divided of {firstNumber} / {secondNumber} = {divide}");
        Debug.Log($"Modul of {firstNumber} % {secondNumber} = {modul}");


        //How to debug my variable on the Debug Log with texts?
        //There are 3 way. The first 
        int number1 = 5;
        int number2 = 6;

        int summary = number1+number2;
        //FIRST WAY - + operator but not as add up like mathematic. It adds string to a string.
        Debug.Log("The summary is: " + summary);
        //OUTPUT: The summary is 11

        //SECOND WAY - Comma , way.
        Console.WriteLine("The summary is: {0} ", summary);
        //OUTPUT: The summary is 11. The {0} is holding space for the variable after the comma

        //THIRD WAY - Dollar sign. $
        Debug.Log($"The summary is: {summary}");
        //OUTPUT: The summary is 11. Same way with comma but it allows to put variable to curly brackets immidiately.


    }

}
