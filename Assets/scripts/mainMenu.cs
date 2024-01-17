using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    // Load Scene
    public void Play() {
        SceneManager.LoadScene("");
    }

    // Quit game
    public void Quit() {
        Application.Quit();
        Debug.Log("Player has quit the Game");
    }
}
