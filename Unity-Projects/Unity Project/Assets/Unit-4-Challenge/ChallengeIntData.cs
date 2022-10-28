using UnityEngine;

namespace Unit_4_Challenge
{
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
}
