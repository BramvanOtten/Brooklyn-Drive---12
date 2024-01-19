using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonParking : MonoBehaviour
{
    public GameObject Parking;
   public void Continue2()
   {
        //als je de button klikt text weg halen
        Parking.SetActive(false);
   }
}

