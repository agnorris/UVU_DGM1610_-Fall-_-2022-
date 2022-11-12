using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    private GameObject gameOverText;
    public AudioSource backgroundMusic;
    public AudioSource endSound;
    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
        backgroundMusic.Play(0); 
    }

    private void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
    }

    void Update()
    {
        if (isGameOver)
        {
            EndGame();
        }
        else
        {
            gameOverText.gameObject.SetActive(false);
        }
    }

    public void EndGame()
    {
        gameOverText.gameObject.SetActive(true);
        endSound.Play(0);
        Time.timeScale = 0;
        backgroundMusic.Pause();
    }
}
