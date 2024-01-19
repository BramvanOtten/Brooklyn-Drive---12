using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class detectionZone : MonoBehaviour
{
    public string tagTarget = "Player";
    public List<Collider> detectedObjs = new List<Collider>();
    public Collider col;
 

    void Start()
    {
        col.GetComponent<Collider>();
    }
 
    // detecteer of een object in de collision zone gekomen is
    void OnTriggerEnter(Collider collider) {
        if(collider.gameObject.tag == tagTarget) {
            detectedObjs.Add(collider);
        }
    }

}