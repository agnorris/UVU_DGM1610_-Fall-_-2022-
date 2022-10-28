using UnityEngine;

namespace Unit_4_Lab
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