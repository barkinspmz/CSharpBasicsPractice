using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes : MonoBehaviour
{
    //Object / Class

    /*
        Imagine that you've a Ford car in your real life. 
        There is some attributes / fields of the car such as color, weight, high speed.
        Also, it has some functions that allow to drive, go backward, etc.. From this example, if we want to 
        create this car in programming, first we should declare what is the name of the object / class?
        The object in this example is the car. Let's create the class named Car. 

        Syntax of Class;
        
        public class Car()
        {
            There will be fields/attributes of the car -variables in Car class-
            Also, we will declare functions / methods in there. 
        }

        When you create any script in Unity, it comes with a class which is inherited from MonoBehavior class.
        so; Let's create some fields to customize our car.

       public class Car()
       {
           string color;
           int weight;
           int maxSpeed;
       }
       
       YEY! We declared color of the car, weight of it and max speed that it can reach. We call each of them field.
       So we will declare some functions to drive that car. We will add DriveForward method which includes line of codes to
       drive forward.
     
       public class Car()
       {
           string color;
           int weight;
           int maxSpeed;

           public void DriveForward()
           {
              driving forward codes..
           }
       }

       Now we have basic Car class that has color, weight, max speed and it has Forward method. 
       As you can see, we created Car object in virtual world with using Classes. It is some kind of 
       blueprint for Car object.
       
       Let's create object/instance of this Car class in Start method.
       
       void Start()
       {
            Car audi = new Car(); 
       }

       In this example, we created audi object which is Car class. Let's define fields in this audi.
       
       void Start()
       {
            Car audi = new Car(); 
            audi.color = "Red"; 
            audi.weight = 1550;
            audi.maxSpeed = 270;
       }

       Now we declared the fields of audi object. We have actual Audi brand car which has red color, 1550kg weight and 270 max speed.
       To create new object, we need to do same thing. We can create objects/instances from Car class as much as we want.

       void Start()
       {
            Car audi = new Car(); 
            audi.color = "Red"; 
            audi.weight = 1550;
            audi.maxSpeed = 270;

            Car bmw = new Car(); 
            bmw.color = "Blue"; 
            bmw.weight = 1350;
            bmw.maxSpeed = 290;
       }
       
       Did you notice something? When we create new instance/object of Car class, we're declaring the fields of it one by one
       with manually. It is waste of time actually. We'll learn new things now. CONSTRUCTORS!!!!!

       CONSTRUCTORS. - An unique technique called a constructor is employed to initialize objects. A constructor's benefit is that it gets invoked whenever a class object is created.
      
       Let's see it in our Car class. 
       
       public class Car()
       {
           string color;
           int weight;
           int maxSpeed;
         
           public Car(string color, int weight, int maxSpeed) - This is constructor. We'll assign parameters to methods to declare fields more easily.
           {
               this.color = color;
               this.weight = weight; 
               this.maxSpeed = maxSpeed; 
           }

           public void DriveForward()
           {
              driving forward codes..
           }
       }

       WE HAVE CONSTRUCTOR NOW! WHEN WE CREATE INSTANCE OF THIS CLASS, THIS CONSTRUCTOR WILL CALLED. LET'S SEE.

       void Start()
       {
            Car audi = new Car("Red", 1550, 270); 

            Car bmw = new Car("Blue", 1350, 290); 
       }
    
       IT LOOKS MORE CLEAR RIGHT? We call it constructor. But there is one more thing. We passed a parameter for constructor.
       If we want to do it with manuel way as we did before, it will get error to us. To solve this problem, you can create one more constructor which is empty. It allow us one more overload for parameter.
       
       public class Car()
       {
           string color;
           int weight;
           int maxSpeed;
         
           public Car(string color, int weight, int maxSpeed) - This is constructor. We'll assign parameters to methods to declare fields more easily.
           {
               this.color = color;
               this.weight = weight; 
               this.maxSpeed = maxSpeed; 
           }

           public Car()
           {
           
           }

           public void DriveForward()
           {
              driving forward codes..
           }
       }
 
      These are the basics of Classes. Welcome to the OOP world! Less code, more objects, better structured codes! 
      
      THERE ARE SOME EXAMPLES BELOW, YOU CAN CHECK IT OUT.
    
     */
    void Start()
    {
        Car carOne = new Car("Red");

        Car carTwo = new Car();
        carTwo.colorOfCar = "Blue";

        //Let's create Ahri's Q skill.
        Skill AhriQ = new Skill("ESSENCE THEFT", "After killing 9 minions or monsters, Ahri heals. After taking down an enemy champion, Ahri heals for a greater amount.", Skill.DamageElement.AP, 75, "Q");

    }

}

public class Car
{
    public string colorOfCar;
    public Car(string color)
    {
        colorOfCar = color;
    }
    
    //Created it to define fields as manually if I needed.
    public Car()
    {

    }
}

//Imagine we're creating League of Legends Skills.

public class Skill
{
    public string name;
    public string description;
    public enum DamageElement {AD, AP}
    public DamageElement damage;

    public int damageAmount;

    public string keyboardKeyToInvoke;

    public Skill()
    {

    }

    public Skill(string name, string description, DamageElement damageElement, int damageAmount, string keyboardKey)
    {
        this.name = name;
        this.description = description;
        this.damage = damageElement;
        this.damageAmount = damageAmount;
        this.keyboardKeyToInvoke = keyboardKey;
    }
}
