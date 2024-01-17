using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreTekst;
    public static int scoreTellen;

    // Start word geroepen voor de eerste frame update
    void Start()
    {
        scoreTekst.text = "Score" + Mathf.Round(scoreTellen);
        
    }

    // Update word geroepen per frame
    void Update()
    {
        
    }
}
