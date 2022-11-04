using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
public class PowerupBehavior : MonoBehaviour

{
    public float speed = 10f;
    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed); 
    }

    }
