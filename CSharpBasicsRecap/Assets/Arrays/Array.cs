using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    /*
    
    ARRAYS - Array is a thing that stores a lot of data which is same type.

    Syntax = Declaring array

    (acces modifier)  (data type)   (name of array)
         public          int[]         numbers;
 
    public int[] numbers;

    - If you want to limit how much element can store in array, you can declare array like below example.
    For example, there will be maximum 5 int data.

    public int[] numbers = new int[5];    -It shows that the maximum capacity of this array is 5.

    - If you want to declare the values while initating array, you can declare the array like below example;

    public int[] numbers = {1, 3421, 123, 12};

    That's great! We learned how to declare array but how we can acces the datas in it?

    Here the new things comes out named INDEX! Index allow you to acces datas in arrays.
    For example; 
                            0    1    2    3 
    public int[] numbers = {1, 3421, 123, 12};

    Index of array starts with 0. First element of array's index is 0. If there is 4 data in array, the last data's index will be 4.

    n = how many data stores
    n-1 = last data of array
     
                                0           1        2
    public string[] names = {"Barkin", "Jonathan", "Tim"};

    We have learned what is index. However, we haven't learned how we acces the data with using index. Let's look at it!


    - IF we want to acces the first element of array and print the name on debug console;

    public string[] names = {"Barkin", "Jonathan", "Tim"};
    
    Debug.Log(names[0]);

    OUTPUT: Barkin

    - If we want to acces second data of array and print the name on debug console;
    
    public string[] names = {"Barkin", "Jonathan", "Tim"};
    
    Debug.Log(names[1]);

    OUTPUT: Jonathan


    Let's do some exercise on below
     */

    public string[] names = { "Barkin", "Tim", "Berfu", "Jonathan" };

    void Start()
    {
        //Usage of Array with FOREACH LOOP. I'll check if the Array named "names" has string value named "Barkin", if yes, it will print out.
        foreach (var name in names)
        {
            if (name == "Barkin")
            {
                Debug.Log("Barkin");
            }
        }

        //Same function with For Loop

        for (int i = 0; i < names.Length; i++)
        {
            if (names[i] == "Barkin")
            {
                Debug.Log(names[i]);
            }
        }
    }
}
