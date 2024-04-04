using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abstraction : MonoBehaviour
{
    /*
    Data abstraction involves concealing specific intricacies while revealing solely fundamental information to the user.

    Abstraction can be accomplished through the utilization of either abstract classes or interfaces.



    The "abstract" keyword is employed for both classes and methods:

    For an Abstract class: It's a constrained class incapable of instantiating objects on its own; it necessitates inheritance from another class to be accessed.
 
    For an Abstract method: It's exclusively used within an abstract class and lacks an implementation body. The implementation is furnished by the subclass (inherited from).
    Moreover, an abstract class can encompass both abstract and conventional methods.

    All the properties or methods in abstract class MUST declared on child class.

    Let's see the practice.
     */
    void Start()
    {
        Venus venus = new Venus();
        Earth earth = new Earth();

        venus.TurnAround(earth);
    }
}

//Basic shape of all the Planet structure. It turns around something, it has name.
public abstract class Planet
{
    public abstract string Name { get; set; }

    public abstract void TurnAround(Planet planet);

}

public class Venus : Planet
{
    public override string Name { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public override void TurnAround(Planet planet)
    {
        //Turning Around a planet. 
    }
}

public class Earth : Planet
{
    public override string Name { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public override void TurnAround(Planet planet)
    {
        //Turning Around a planet. 
    }
}


