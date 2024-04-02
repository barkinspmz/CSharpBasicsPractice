using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Properties : MonoBehaviour
{
    /*
         PROPERTIES | ENCAPSULATION.
         
         We know that there are some acces modifiers. In the class, generally, we do not want to private fields accesed from the outside of the class. Because it can cause problems if the field is changed from outside. To make a more controlable private fields which can be accesed from outside of the class is that properties!

        Syntax;
     
        - The Get method is for getting value inside of name field, Set method is fot setting value of "name" field.
        private string name;
        public string Name
        {
           get 
           {
               return name;
           }
      
           set
           {
               name = value;
           }
        }
       
        For ex: The name field of Car class is private. We wanna make it read-only (can acces from other scripts but cannot change the value in it.)  
        
        1- First we declared string field named "name". 
        2- To make it accesable from other scripts, we created property. The first letter need to be uppercase!* 

         public class Car 
         {
            private string name;
            public string Name {get {return name;} private set{};};
         }

        3- We can call Name property from outside of script but we cannot set it from the outside of the class because the setter method is private. We can only set it in Car class.

        BUT.. WHAT WE SAID? MAKE IT ACCESSIBLE IN OTHER CLASSES WITH MORE CONTROLABLE WAY. SO IMAGINE THAT YOU'VE HEALTH FIELD BUT IT CANNOT BE MORE THAN 100 BECAUSE IT IS THE MAX LIMIT OF IT. IF WE WANT TO SET IT IN OUTSIDE OF THE CLASS, WE HAVE TO WRITE THE CONDITION TO ALLOW SET VALUE IN THIS FIELD.
        LET'S SEE.

        EXAMPLE:
     
        public class Player 
        {
           private string name;
           private int health;
           public int Health
           {
              get { return health; }
             
              set {
                    if(value<=100) { health = value }
                    else { Debug.Log("You cannot set value more than 100!");
                  }
           }
        }

        In this example; We created property named Health which is accesable and can be set from outside of the Player class. However, to set a value in it, there are some conditions. The value cannot more than 100. If it is, there will be bug log.

        Do not forget, game dev is collab job with your colleagues. Some developer cannot understand what you did and can try to change value outside of the class. To prevent bugs, we use Property!
                         
    */

    private string name;
    public string Name
    {
        get { return name; }
        set
        {
            if (name.Length<15)
            {
                name = value;
            }
            else
            {
                Debug.Log("It cannot be assign");
            }
        }
    }
    void Start()
    {
        Name = "DFKAFFKJAASDFAASFSDSFDFADSAFSDASDFASDFSFDL";
        Debug.Log(Name);
    }
}
