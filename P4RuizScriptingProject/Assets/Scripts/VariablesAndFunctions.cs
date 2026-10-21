
using System.Collections;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    // This is a variable
    int myInt = 36;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(myInt);
        myInt = MultiplyByTwo(myInt);
        Debug.Log (myInt);
    }

    int MultiplyByTwo (int number)
    {
        //update is called once per frame
   

        //This is a function
        {
            int result;
            result = number * 2;
            return result;
        }
    }


        
    }

