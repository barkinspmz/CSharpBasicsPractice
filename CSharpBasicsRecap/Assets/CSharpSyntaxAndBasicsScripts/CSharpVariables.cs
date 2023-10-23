using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSharpVariables : MonoBehaviour
{
    /*
       
        Variables are the containers for storing specific data values.
        In C#, there are different type of variables, for example;
      
        int - it stores integers Ex: int a = 10;
        long - it stores integers too but has much more capacity for value Ex: int a = 12312312;
        float - it stores floating numbers Ex: float a = 10.5f;
        double- it stores floating numbers too but has much more capacity for value Ex: double num = 10.51231f;
        char - it stores single characters Ex: char c = 'a';
        string - stores texts Ex: string name = "Barkýn";
        bool - stores only two states: true or false Ex: bool isAlive = true;
        
        Declaring variable in C#
        type variableName = value;

        The variable name need to be clear and identify the job of variable. For example: 
        
        int currentHealthPoint = 100; *It is the right way. 
        int a = 100; *It is the wrong way. WHAT is this "a" means? NOTHING.
        

        CONSTANTS!
        If you don't want to change the value of variable, you can add "const" keyword 
        in front of the variable type and it will be read-only variable. It will keep
        in the same value. It can be beneficial to use it in Pi number. Pi is a constant
        number and no one can change it.


        C# DATA TYPES | 
        int | 4 bytes | Stores whole numbers from -2,147,483,648 to 2,147,483,647
        long | 8 bytes | Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
        float | 4 bytes | Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
        double | 8 bytes | Stores fractional numbers. Sufficient for storing 15 decimal digits
        bool | 1 bit | Stores true or false values
        char | 2 bytes | Stores a single character/letter, surrounded by single quotes
        string | 2 bytes per character | Stores a sequence of characters, surrounded by double quotes



     */

    //This method works for once when hit the play.
    void Start()
    {
        //Let's declare some variables!
        int firstNumber = 5;
        float firstFloatingNumber = 7.5f;

        //Constant example | It becomes read-only.
        const float piNumber = 3.14f;
    }
}
