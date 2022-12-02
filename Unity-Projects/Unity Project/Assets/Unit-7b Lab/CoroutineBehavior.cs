using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehavior : MonoBehaviour
{
    public UnityEvent repeatEvent;

    public int counterNum = 3;
    public float seconds = 3.0f;
    private WaitForSeconds wfsobj;
    private WaitForFixedUpdate wffuobj;

    IEnumerator Start()
    {
        wfsobj = new WaitForSeconds(seconds);
        wffuobj = new WaitForFixedUpdate();

        while (counterNum > 0)
        {
            yield return wfsobj;
            repeatEvent.Invoke();
        }
    }
}
