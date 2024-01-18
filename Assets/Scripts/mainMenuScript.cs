using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuScript : MonoBehaviour
{
    // Gekozen Scenario laden
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

    public void Scenario5() {
        SceneManager.LoadScene("Scenario5");
    }

    public void Scenario6() {
        SceneManager.LoadScene("Scenario6");
    }

    public void Scenario7() {
        SceneManager.LoadScene("Scenario7");
    }

    public void Scenario8() {
        SceneManager.LoadScene("Scenario8");
    }
    
    // Quit mogelijkheid
    public void Quit() {
        Debug.Log("De Speler heeft het spel verlaten");
    }
}
