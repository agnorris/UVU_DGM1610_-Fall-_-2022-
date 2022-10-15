using UnityEngine;

[CreateAssetMenu]
public class ChallengeFloatData : ScriptableObject
{
    public float value;

    public void UpdateValue()
    {
        value += 1.5f;
    }
}
