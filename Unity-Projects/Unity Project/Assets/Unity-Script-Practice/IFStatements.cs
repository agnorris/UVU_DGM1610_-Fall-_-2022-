using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour
{
    float teaTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        teaTemperature -= Time.deltaTime * 5f;
    }


    void TemperatureTest()
    {
        if (teaTemperature > hotLimitTemperature)
        {
            print("The tea is too hot to drink.");
        }
        else if (teaTemperature < coldLimitTemperature)
        {
            print("The tea is too cold to drink.");
        }
        else
        {
            print("The tea is just right.");
        }
    }
}