using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class parkingCanvas : MonoBehaviour
{
    public GameObject Parking;

    void OnTriggerEnter(Collider colliderParking)
    {
        //activeer de volgende navigatie nadat je de waypoint behaald hebt
        Parking.SetActive(true);
    }
}
