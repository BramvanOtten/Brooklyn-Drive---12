using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuScript : MonoBehaviour
{
    // Scenario Menu openen
    public void Scenario() {
        SceneManager.LoadScene("");
    }

    public void Quit() {
        Debug.Log("De Speler heeft het spel verlaten");
    }
}
