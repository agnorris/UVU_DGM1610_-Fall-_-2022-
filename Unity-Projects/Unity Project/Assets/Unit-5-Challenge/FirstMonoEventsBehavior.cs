using UnityEngine;
using UnityEngine.Events;

public class FirstMonoEventsBehavior : MonoBehaviour
{
    private void OnBecameVisible()
    {
        enabled = true;
    }

    private void OnBecameInvisible()
    {
        enabled = false;
    }
}
