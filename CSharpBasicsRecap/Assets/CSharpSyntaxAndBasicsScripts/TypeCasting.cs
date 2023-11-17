using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeCasting : MonoBehaviour
{
    /*
          In some cases, you need to convert the type of your variable.
          In this converting process, some variable type size is bigger than others.
          It means that you cannot convert those variable types automatically. So, there
          is two different types of type casting. These are;
       
          - Implicit Casting (Automatically) : converting the smaller variable type to a larger
          types. 
     
          - Explicit Casting (Manually): converting larger type variable to smaller type.

          *You can think it as you can put smaller box into larger box right? You don't need to
          adjust the size of larger box because the smaller box can fit into larger box easily. It is actually
          implicit casting. You don't need to work manually to convert the type of variable.
          
          *But what happens when you try to put larger box into the smaller box? You HAVE TO adjust the size of 
          larger box to fit in the smaller box. In that case, you're doing MANUEL job. It is the explicit casting!

          For example the size of integer type in memory is 2bytes. The size of long type in memory is 4bytes.
          Long takes more spaces than int, so long (4bytes) > int (2bytes)
          
          EXP:

          IMPLICIT CASTING -
          int health = 100;
          long currentHealth = health;
          
          The "health" is transformming the data to currentHealth variable which is long type automatically. Because
          4bytes > 2bytes. We put the small box into the larger box.

          ------------------------------------------------

          EXPLICIT CASTING -
          long health = 100;
          int currentHealth = (int)health;
          The "health" is transforming the data to currentHealth variable which is int so we had to do it manually. We putted the large
          box into the smaller box. That's why we did it MANUALLY. You can do it with 2 different ways.
          
          With using Type Conversion Methods or putting brackets with the type that you want to convert.
          
          Let's see how we can use these things works on Start method.     
           
    */
    void Start()
    {
        //You can use Debug class to print out some text to Debug tab.
        //We're using those things for bug fix or checking systems are working or not.
        Debug.Log("This method called from TypeCasting class.");

        int health = 100;
        long currentHealth = health;
        //AUTOMATICALLY CONVERTED INT TO LONG.

        double doubleNum = 3.121232121123f;
        //float floatNum = doubleNum; **This will give error because we cannot convert large size type to smaller type size automatically.
        float floatNum = (float)doubleNum;

        //OR we can do the same thing with using Convert class.

        float floatNum2 = Convert.ToSingle(doubleNum);

        //You can now check the is it converted double to float or not when you started the game. It will appear on Debug TAB.
        Debug.Log($"The number while it was double is: {doubleNum} and when we converted it to float, it is now : {floatNum} ");


    }
}
