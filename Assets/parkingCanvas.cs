using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class parkingCanvas : MonoBehaviour
{
    public GameObject Parking;

    void OnTriggerEnter(Collider colliderParking)
    {
        Parking.SetActive(true);
    }
}
