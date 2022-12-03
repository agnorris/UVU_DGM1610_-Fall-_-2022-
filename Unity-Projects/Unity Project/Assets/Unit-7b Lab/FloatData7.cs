using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatData7 : ScriptableObject
{
    public float value;

    public void UpdateValue(float num)
    {
        value += num;
    }

}