using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMenu : MonoBehaviour {
    public void PlayGame() {
        SceneManager.LoadScene("__Scene_0");
    }

    public void PlayTutorial() {
        SceneManager.LoadScene("Tutorial");
    }

    public void GoBackToHome() {
        SceneManager.LoadScene("StartMenu");
    }

    public void QuitGame() {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
