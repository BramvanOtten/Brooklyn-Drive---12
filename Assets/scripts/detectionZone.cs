using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class detectionZone : MonoBehaviour
{
    public string tagTarget = "Player";
    public List<Collider> detectedObjs = new List<Collider>();
    public Collider col;
 
    // Start is called before the first frame update
    void Start()
    {
        col.GetComponent<Collider>();
    }
 
    // Detect when objects enter the detectionZone
    void OnTriggerEnter(Collider collider) {
        if(collider.gameObject.tag == tagTarget) {
            detectedObjs.Add(collider);
        }
    }

    void OnTriggerExit(Collider collider) {
        if(collider.gameObject.tag == tagTarget) {
            detectedObjs.Remove(collider);
        }
    }
}