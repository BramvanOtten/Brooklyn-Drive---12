using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class moveForward : MonoBehaviour
{
    public float speed = 15.0f;
    public detectionZone detectionZone;
    Collider physicsCollider;
 
    void FixedUpdate() {
        // Detect if Player is in the vacinity
        if(detectionZone.detectedObjs.Count > 0) {
            // Move object if player is in vacinity
            Debug.Log("Player detected");
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

    }
}