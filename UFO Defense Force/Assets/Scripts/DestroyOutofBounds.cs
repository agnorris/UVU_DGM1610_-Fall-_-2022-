using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    public float topBounds = 50.0f;
    public float lowerBounds = -10f;
    public GameManager gameManager;
   
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void Update()
    {
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBounds)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
            gameManager.isGameOver = true;
        }
    }
}
