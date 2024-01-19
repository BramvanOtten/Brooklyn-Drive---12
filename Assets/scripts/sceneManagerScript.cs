using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManagerScript : MonoBehaviour
{
    // Load selected Scene 
    public void Scenario1() {
        SceneManager.LoadScene("Scenario1");
    }

    public void Scenario2() {
        SceneManager.LoadScene("Scenario2");
    }
}