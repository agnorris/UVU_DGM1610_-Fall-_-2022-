using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



public class CoroutineBehavior : MonoBehaviour
{
    public UnityEvent startCountEvent, startEvent, repeatEvent, repeatCountEvent,endCountEvent, endEvent, repeatUntilFalseEvent;

    public bool canRun;
    public IntData counterNum;
    public float seconds = 3.0f;
    private WaitForSeconds wfsobj;
    private WaitForFixedUpdate wffuobj;

    private void Start()
    {
        wfsobj = new WaitForSeconds(seconds);
        wffuobj = new WaitForFixedUpdate();
        startEvent.Invoke();
    }

    private IEnumerator RepeatUntilFalse()
    {
        while (canRun)
        {
            yield return wfsobj;
            repeatUntilFalseEvent.Invoke();
        }
    } 
    private IEnumerator Counting()
    {
        
        startCountEvent.Invoke();
        yield return wfsobj;
        while (counterNum.value > 0)
        {
            repeatCountEvent.Invoke();
            counterNum.value--;
            yield return wfsobj;
        }
        endCountEvent.Invoke();
    }
    public void StartCounting()
    {
        StartCoroutine(Counting());
    }

   

    public void StartRepeatUntilFalse()
    {
        canRun = true;
        StartCoroutine(RepeatUntilFalse());
    }
}