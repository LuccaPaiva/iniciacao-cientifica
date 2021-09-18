using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{
    public void LoadArScene() {
        SceneManager.LoadScene("ArGreetingCard");
    }

    public void ExitApp() {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void LoadMenuScene() {
        SceneManager.LoadScene("MenuScene");
    }
}
