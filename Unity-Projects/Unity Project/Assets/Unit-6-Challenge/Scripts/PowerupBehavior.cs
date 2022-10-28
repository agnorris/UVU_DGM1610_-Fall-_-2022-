using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PowerupBehavior : MonoBehaviour

{
    public float speed = 10.0f;
    private Rigidbody _powerup;
    private GameObject powerup;

    void Start()
    {
        Instantiate(powerup);
        GetComponent<Renderer>().enabled = false;
        powerup.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            powerup.GetComponent<Renderer>().enabled = true;
            powerup.SetActive(true);
        }
        _powerup = this.GetComponent<Rigidbody>();
        _powerup.velocity = new Vector3(-speed, 0, 0);
    }

    }
}