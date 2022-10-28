using UnityEngine;
using UnityEngine.Events;

namespace Unit_4_Challenge
{
    public class EnterBehavior : MonoBehaviour
    {
        public UnityEvent enterEvent;

        private void OnTriggerEnter(Collider other)
        {
            enterEvent.Invoke();
        }
    }
}
