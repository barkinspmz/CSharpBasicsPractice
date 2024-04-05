using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interfaces : MonoBehaviour
{
    /*
     
    An interface is a completely "abstract class", which can only contain abstract methods and properties (with empty bodies): W3.SCHOOL DEFINITION*

    It is considered good practice to start with the letter "I" at the beginning of an interface, as it makes it easier for yourself and others to remember that it is an interface and not a class.

    By default, members of an interface are abstract and public.

    Note: Interfaces can contain properties and methods, but not fields.

    The method cannot include body on interfaces!!!

   
    Let's see it with practice. 

    */
    void Start()
    {
        Door door = new Door();
        door.Interacted();
    }
}

public interface IInteractable
{
    public void Interacted();
}
public interface IShootable
{
    public void Shooted();
}

//YOU CAN ASSIGN CLASS TO INTERFACES AS MANY AS YOU WANT WITH USING COMMA
public class Door : IInteractable, IShootable
{
    //IInteractable interface says that Door Class MUST implement Interacted method.

    public void Interacted()
    {
        Debug.Log("Door has been interacted with player");
    }

    public void Shooted()
    {
        Debug.Log("Door has been shooted by player");
    }
}
