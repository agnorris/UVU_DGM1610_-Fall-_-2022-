using UnityEngine;
using UnityEngine.Events;

public class EnterBehavior : MonoBehaviour
{
    public UnityEvent enterEvent;

    private void OnTriggerEnter(Collider other)
    {
        enterEvent.Invoke();
    }
}
