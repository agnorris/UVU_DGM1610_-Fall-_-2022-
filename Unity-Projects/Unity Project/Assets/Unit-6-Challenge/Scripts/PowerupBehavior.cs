using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PowerupBehavior : MonoBehaviour

{
    public float speed = 10.0f;
    private Rigidbody _powerup;

    private void Start()
    {
        _powerup = this.GetComponent<Rigidbody>();
        _powerup.velocity = new Vector3(-speed, 0, 0);
    }

    }
