using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public static bool gepauzeerd = false;
    public GameObject PauzeMenuCanvas;       // PauzeMenuCanvas object in de game

    // Start word geroepen voor de eerste frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update word geroepen per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))    // If escape ingedrukt word
        {
            if (gepauzeerd)                     // Als gepauzeerd, speel game verder af
            {
                Verder();
            }
            else                                // Anders, game op pauze
            {
                Stop();
            }
        }
    }

    void Stop()                                 // Zet de game op pauze
    {
        PauzeMenuCanvas.SetActive(true);
        Time.timeScale = 0f;
        gepauzeerd = true;
    }

    public void Verder()                               // Laat de game verder gaan
    {
        PauzeMenuCanvas.SetActive(false);
        Time.timeScale = 1f;
        gepauzeerd = false;
    }

    public void MainMenuKnop()          // Knop voor MainMenu
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);       // Gaat naar MainMenu scene wanneer je hier op klikt
    }
}
