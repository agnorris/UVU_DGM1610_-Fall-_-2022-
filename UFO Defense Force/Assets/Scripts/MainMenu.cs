using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int sceneToLoad;
    public AudioSource buttonSound;

    public void StartGame()
    {
        SceneManager.LoadScene(sceneToLoad);
        buttonSound.Play(0);
        Debug.Log("New Scene Loaded!");
    }
    
    public void QuitGame()
    {
        Application.Quit();
        buttonSound.Play(0);
        Debug.Log("Quit Game!");
    }
}
