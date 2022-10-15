using UnityEngine;

[CreateAssetMenu]
public class ChallengeIntData : ScriptableObject
{
    public int value;

    public void SetValue (int num)
    { 
        value = num; 
    }
    public void Increment()
    {
        value++;
    }
}
