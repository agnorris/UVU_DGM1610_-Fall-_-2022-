using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehavior : MonoBehaviour
{
    public UnityEvent startEvent, repeatEvent,endEvent;

    public IntData counterNum;
    public float seconds = 3.0f;
    private WaitForSeconds wfsobj;
    private WaitForFixedUpdate wffuobj;

    IEnumerator Start()
    {
        wfsobj = new WaitForSeconds(seconds);
        wffuobj = new WaitForFixedUpdate();
        startEvent.Invoke();
        yield return wfsobj;
        while (counterNum.value > 0)
        {
            repeatEvent.Invoke();
            counterNum.value--;
            yield return wfsobj;
        }
        endEvent.Invoke();
    }
}
