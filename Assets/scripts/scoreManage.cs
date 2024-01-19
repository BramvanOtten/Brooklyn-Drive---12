using System.Security.Cryptography.X509Certificates;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreManage : MonoBehaviour
{
    public static scoreManage instance;

    public TMP_Text scoreText;
    public int currentScore = 0;

    void Awake()
    {
            instance = this;
    }

    void Start()
    {
        LoadScore();
    }

    public void IncreaseCurrentScore(int value)
    {
        currentScore += value;
        scoreText.text = "Score: " + currentScore.ToString();

        SaveScore();
    }

    public void SaveScore()
    {
        PlayerPrefs.SetInt("Score", currentScore);
        PlayerPrefs.Save();
    }

    private void LoadScore()
    {
        currentScore = PlayerPrefs.GetInt("Score", 0);
        scoreText.text = "Score: " + currentScore.ToString();
        Debug.Log("Loaded Player Score: " + currentScore);
    }
}