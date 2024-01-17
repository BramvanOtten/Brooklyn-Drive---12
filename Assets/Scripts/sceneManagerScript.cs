using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManagerScript : MonoBehaviour
{
    // Load selected scene
    public void Scenario1() {
        SceneManager.LoadScene("Scenario1");
    }
}
