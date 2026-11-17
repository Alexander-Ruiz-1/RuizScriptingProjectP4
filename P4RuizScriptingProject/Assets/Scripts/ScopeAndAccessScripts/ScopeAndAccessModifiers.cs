using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class ScopeAndAccessModifiers : MonoBehaviour
{


    //Added a public variable to the class
    public int alpha = 5;

    //added a private variable to the class
    private int beta = 0;
    private int gamma = 5;

    //add access to another class
    private AnotherClass myOtherClass;


    //Start is called before the first frame update

    void Start()
    {
        //change the starting value of alpha
        alpha = 29;

        myOtherClass = new AnotherClass();
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);
    }


    void Example (int pens, int crayons)
    {
        int answer;
            answer = pens * crayons * alpha;
        Debug.Log(answer);
    }




    // Update is called once per frame
    void Update()
    {
        Debug.Log("Alpha is set to: " + alpha);
    }
}
    

    
