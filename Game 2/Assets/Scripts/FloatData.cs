using UnityEngine;

namespace Game2
{
    [CreateAssetMenu]

    public class FloatData : ScriptableObject
    {
        public float value;

        public void UpdateValue(float num)
        {
            value += num;   
        }
    }
}