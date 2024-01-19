using System.Security.Cryptography.X509Certificates;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreManage : MonoBehaviour
{
    public static scoreManage instance;

    public TMP_Text scoreTekst;
    public int huidigeScore = 0;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        scoreLaden();
    }

    public void huidigeScoreVerhogen(int value)
    {
        huidigeScore += value;
        scoreTekst.text = "Score: " + huidigeScore.ToString();

        scoreOpslaan();
    }

    public void scoreOpslaan()
    {
        PlayerPrefs.SetInt("Score", huidigeScore);
        PlayerPrefs.Save();
    }

    private void scoreLaden()
    {
        huidigeScore = PlayerPrefs.GetInt("Score", 0);
        scoreTekst.text = "Score: " + huidigeScore.ToString();
        Debug.Log("Loaded Player Score: " + huidigeScore);
    }
}