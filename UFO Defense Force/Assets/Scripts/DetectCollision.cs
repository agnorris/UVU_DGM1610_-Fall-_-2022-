using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public ScoreManager scoreManager;
    public int scoreToGive;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        scoreManager.IncreaseScore(scoreToGive);
        Destroy(this.gameObject);
        Destroy(other.gameObject);
    }
}
