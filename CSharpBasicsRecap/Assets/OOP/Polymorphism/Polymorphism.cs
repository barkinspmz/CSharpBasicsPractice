using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Polymorphism : MonoBehaviour
{
    /*
     
    As you can understand from the name of it, it allow us to use functions with many form. Let's practice to understand what it means.

    Let's create base/parent Animal class.

    public class Animals 
    {
       protected string name;
       
       public void Talk()
       { 
           Debug.Log("ROOAWWW");
       }
    }

    public class Cat
    {
       public void Talk()
       {
           Debug.Log("MEOWWW");
       }
    }

    private void Start()
    {
        Cat cat = new Cat();
        cat.Talk();
    }

    OUTPUT : ROOAWWW - It comes from Animals class.

    It is not the OUTPUT that we want. There is 2 method with same name but the output comes from base class only. IT IS THE TIME WHERE THE POLYMORPHISM COMES OUT!
    
    To make it override, let's see how polymorphism works. 

    2 keyword. VIRTUAL AND OVERRIDE.

    - The method that stays in base class need to has VIRTUAL keyword.

    public class Animals 
    {
       protected string name;
       
       public virtual void Talk()
       { 
           Debug.Log("ROOAWWW");
       }
    }

    public class Cat
    {
       public override void Talk()
       {
           Debug.Log("MEOWWW");
       }
    }

    private void Start()
    {
        Cat cat = new Cat();
        cat.Talk();
    }

    OUTPUT: MEOWWW - WE GOT IT!

    HERE WE GO! There is a method name Talk but the method that located in Child class has different function than base class's Talk method.

    We call it Polymorphism. Same name, different function. - KEYWORDS: Virtual | Override 

    LET'S MAKE SOME PRACTICE.
     */
    void Start()
    {
        Weapon weaponOne = new Weapon("AK-47", 0);
        weaponOne.FunctionWhenInteracted();
    }
}

// PRACTICE;

public class Item
{
    protected string name;
    protected int id;

    public virtual void FunctionWhenInteracted()
    {
        Debug.Log("Interacted!");
    }
}

public class Weapon : Item
{
    public Weapon(string name, int id)
    {
        this.name = name;
        this.id = id;
    }

    public override void FunctionWhenInteracted() 
    {
        Debug.Log("Shooting!");
    }
}
