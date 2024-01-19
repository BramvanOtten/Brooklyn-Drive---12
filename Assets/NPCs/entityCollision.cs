using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class entityCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision) {
        // Checken of de player met de finish line collides
        if (collision.gameObject.CompareTag("Player"))
        {
            // Run de void aanrijding
            Aanrijding();
        }
    }
    void Aanrijding() {
        Debug.Log("Aanrijding");
    }
}
