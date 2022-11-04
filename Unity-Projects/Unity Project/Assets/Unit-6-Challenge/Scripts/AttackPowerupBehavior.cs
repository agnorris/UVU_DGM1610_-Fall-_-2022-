using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPowerupBehavior : MonoBehaviour
{
    public float speed = 8f;
    public Color startcolor = Color.white;
    public Color endcolor = Color.cyan;
    public float interval = 1f;

    private void Awake()
    {
        GetComponent<Renderer>();
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        GetComponent<Renderer>().material.color = Color.Lerp(startcolor, endcolor, Mathf.PingPong(Time.time, 1));
    }
}
