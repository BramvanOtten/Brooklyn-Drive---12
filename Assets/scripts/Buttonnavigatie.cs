using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttonnavigatie : MonoBehaviour
{
    public GameObject Navigatie;
   public void Continue()
   {
        //canvas uitzetten
        Navigatie.SetActive(false);
   }
}