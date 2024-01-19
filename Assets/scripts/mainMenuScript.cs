using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuScript : MonoBehaviour
{
    // Scenario's openen
    public void Scenario1() {
        SceneManager.LoadScene("Scenario1");
    }

    public void Scenario2() {
        SceneManager.LoadScene("Scenario2");
    }

    public void Scenario3() {
        SceneManager.LoadScene("Scenario3");
    }

    public void Scenario4() {
        SceneManager.LoadScene("Scenario4");
    }

    // Quit mogelijkheid
    public void Quit() {
        Debug.Log("De Speler heeft het spel verlaten");
    }
}
