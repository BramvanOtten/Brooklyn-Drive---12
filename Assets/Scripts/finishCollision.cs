using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class finishCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Checken of de player met de finish line collides
        if (collision.gameObject.CompareTag("Player"))
        {
            // Run de void afgerond
            Afgerond();
        }
    }
 
    void Afgerond()
    {
        // Menu scene laden
        SceneManager.LoadScene("mainMenu");
        // Debug.Log("Afgerond");  
    }
}