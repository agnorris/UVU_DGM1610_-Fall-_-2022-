using UnityEngine;

namespace Unit_5_Challenge
{
    public class SecondMonoBehaviorEvent : MonoBehaviour
    {
        public void OnCollisionEnter()
        {
            Debug.Log("Collision");
        }

        public void OnCollisionExit()
        {
            Debug.Log("No longer a collision");
        }
    }
}
