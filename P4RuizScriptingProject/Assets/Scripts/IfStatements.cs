using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    // Start is called before the first frame update
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            
        {
            TemperatureTest();
        }

        coffeeTemperature -= Time.deltaTime * 5f;
    }

    // Update is called once per frame
    void TemperatureTest()
    {
        //If the coffee's temperature is greater than the hottest drinking temperature...
        if (coffeeTemperature > hotLimitTemperature)
        {
            // ...Do This
            print("Coffee is too hot.");
        }
        //If it isn't, but the coffee temperature is less than the coldest drinking temperature...
        else if (coffeeTemperature < coldLimitTemperature)
        {
            //... Do This
            print("Coffee is too cold.");
        }
        //If it is neither of those...
        else
        {
            //... Do This
            print("Coffee is just right.");
        }


    }
}
