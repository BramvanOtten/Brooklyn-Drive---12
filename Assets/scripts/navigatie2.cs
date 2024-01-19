using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class navigatie2 : MonoBehaviour
{
    public GameObject Waypoints;


    void OnTriggerEnter(Collider collider)
    {
        // waypoints uitzetten als je in de hitbox komt
        Waypoints.SetActive(false);
    }
}
