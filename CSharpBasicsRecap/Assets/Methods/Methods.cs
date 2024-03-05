using UnityEngine;

public class Methods : MonoBehaviour
{
    /*
       METHODS.
            
              It allow us to write more readable codes. For example: Wheel. The function of wheel is the 
       executed code in Method. The all function code stays inside of method named Wheel(); when we call it
       it in anywhere, it will make the Wheel function.

      Syntax; accesModifier_returnType_methodName()
              {
                 Executed code.
              }

              acces  return  method
           modifier   type    name
      FOR EX: public void KillPlayer() 
             {
                 Destroy(this.gameObject);
             }


      # The methods contains line of codes. 
      
      ## PARAMETERS
      You can get some data from outside of the Method with using 
      parameters. 
      
      FOR EXAMPLE;
                
                int currentHealth = 100;

                public void DecreaseHealth(int damageAmount)
                {
                      currentHealth -= damageAmount;
                }

      It decrease the current health in terms of given damage amount from outside of the method.   
      
      #  RETURN TYPE METHODS 

      These type of methods are returning value only.
      They can take parameters too. 
      
      public int SumOfTwoNumber(int number1, number2)
      {
          int sum  = number1+number2;
          return sum;
      }
     
      This method will return the sum of the two numbers in parameters.
       
      string playerName;
    
      public string GiveName(string playerName)
      {
           this.playerName = playerName;
      }
     
     LET'S PRACTICE!
      
     */
    void Start()
    {
        Debug.Log(SumOfTwoNumbers(5, 6));
        Debug.Log(PuttingEmptySpaceBetweenNameAndSurname("Jonathan","Davey"));
    }


    private int SumOfTwoNumbers(int number1, int number2)
    {
        return number1 + number2;
    }

    private string PuttingEmptySpaceBetweenNameAndSurname(string name, string surname)
    {
        return name + " "+ surname;
    }
}
