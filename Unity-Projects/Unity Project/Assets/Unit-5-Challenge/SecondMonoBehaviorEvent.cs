using UnityEngine;
using UnityEngine.Events;

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
