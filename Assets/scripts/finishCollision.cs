using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;
using UnityEngine.UI;

public class finishCollision : MonoBehaviour
{
    public Text logTxt;
    public int value;

    void OnCollisionEnter(Collision collision)
    {
        // Checken of de player met de finish line collides
        if (collision.gameObject.CompareTag("Player"))
        {
            Afgerond();
            Debug.Log("Collided");
        }
    }

    void Afgerond()
    {
        // Menu scene laden
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);       // Gaat naar MainMenu scene wanneer je hier op klikt
        logTxt.text = "Afgerond";  
        Debug.Log("Afgerond");
    }
}
