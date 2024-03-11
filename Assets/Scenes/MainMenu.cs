using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ExitGame() 
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void StartGame()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        Debug.Log("Deneme123");
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
