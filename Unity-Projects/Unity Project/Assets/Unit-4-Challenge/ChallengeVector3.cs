using UnityEngine;

[CreateAssetMenu]
public class ChallengeVector3 : ScriptableObject
{
    public Vector3 value;

    public void IncrementX()
    {
        value.Set(value.x + 1, value.y, value.z);
    }

    public void IncrementY()
    { 
        value.Set(value.x, value.y + 1, value.z);   
    }

    public void IncrementZ()
    { 
        value.Set(value.x, value.y, value.z + 1); 
    }
}
