using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class moveForward : MonoBehaviour
{
    public float speed = 15.0f;
    public detectionZone detectionZone;
    Collider physicsCollider;
 
    void FixedUpdate() {
        // check of de player in de hitbox zit
        if(detectionZone.detectedObjs.Count > 0) {
            // move object als de player in de hitbox zit
            Debug.Log("Player detected");
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

    }
}