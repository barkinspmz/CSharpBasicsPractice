using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inheritance : MonoBehaviour
{
    /*
       INHERITANCE - 
        C# allow that the fields and methods can pass from one class to another class. We call it Inheritance. 
        This concept implemented when you create a new C# script in Unity. Our created custom class has inherited by
        MonoBehaviour class. We can use the methods and fields from MonoBehavior class with it. 

       Syntax; 
       The Audi class is inherited from Car class. The Audi class can use all the Car class fields and methods.
       
       We use colons before the parent class when we get inheritance. Audi is child class of Car class.
     
       public class Audi : Car
       {
           string extraTurbo;
       }

       with this Audi class that inherited from Car class can be specified with fields and methods which is not general thing for all the Car classes. All car have color, max and minSpeed, DriveForward function, etc.. but Audi may have different specific fields such as extra turbo.
      
       PARENT AND CHILD CLASS - 
       The child class is the inherited class. We call them child because it is inherited from parent class. 
       Generally Parent Class has general fields and functions that include all the child classes have. However, the child class might have different specific fields and methods. That's why we use inheritance. All brand of cars have wheels, max speed & min speed that can reach but having turbo system might be different in other brands. To specify it, we use inheritance. Imagine that we will create Audi cars in programming world.  

       Practice 1 : Create an Audi which is inherited from Car class.
      
       public class Car
       {
         protected string nameOfCar;
         protected int minSpeed;
         protected int maxSpeed;
          
         DriveForward() { }
       }

       public class Audi : Car
       {
         public Audi (string name, int minSpeed, int maxSpeed)
         {
           this.nameOfCar = name;
           this.minSpeed = minSpeed;  
           this.maxSpeed = maxSpeed;
         }

         void ExtraTurbo() { }
       }
       
       ** WHEN WE GENERATE THE OBJECT OF AUDI, WE HAVE A CHANCE TO ACCES ALL OF THE CAR CLASS'S FIELDS AND METHODS.
       LET'S LOOK.
       
       private void Start()
       {
           Audi audi = new Audi("Audi", 0, 275);
       }
      
      EXAMPLE: There are lots of nationalities in our world. All the nationality has their own name, own flag, their policy, etc.. But there are some specific fields of natonalites which seperates each other such as fields that come from culture.

      LET'S SEE THE EXAMPLE WITH PRACTICED WAY. 
     
     */
    void Start()
    {
        //Nationality Example
        Turkey turkey = new Turkey("Turkey", "Red-White", "..", true);

        //Car Example
        Audi audi = new Audi("Audi",0, 275);
    }

    
    void Update()
    {
        
    }
}

// NATIONALITY EXAMPLE 
public class Nation
{
    protected string name;
    protected string flag;
}

public class Turkey : Nation
{
    string culture;
    bool hasKurdishProblem;
    public Turkey(string name, string flag, string culture, bool hasKurdishProblem)
    {
        this.name = name;
        this.flag = flag;
        this.culture = culture;
        this.hasKurdishProblem = hasKurdishProblem;
    }
}

// CAR EXAMPLE
public class CarR
{
    protected string nameOfCar = "";
    protected int minSpeed;
    protected int maxSpeed;

    void DriveForward() { }
}

public class Audi : CarR
{
    
    public Audi(string name, int minSpeed, int maxSpeed) 
    { 
        this.nameOfCar = name;
        this.minSpeed = minSpeed;
        this.maxSpeed = maxSpeed;
    }

    void ExtraTurbo() { 
    }
}
