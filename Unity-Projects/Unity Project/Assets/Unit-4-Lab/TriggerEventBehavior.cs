using UnityEngine;
using UnityEngine.Events;

namespace Unit_4_Lab
{
    public class TriggerEventBehavior : MonoBehaviour
    {
        public UnityEvent triggerEnterEvent;

        private void OnTriggerEnter(Collider other)
        {
            triggerEnterEvent.Invoke();
        }
    }
}
