using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class HorizontalMove : MonoBehaviour
{
    public float speed = 10.0f;
    void Update()
    {
        transform.Translate(Vector3.right * (Time.deltaTime * speed));
    }
}
