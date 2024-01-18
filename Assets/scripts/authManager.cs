using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Services.Core;
using Unity.Services.Authentication;
using System.Threading.Tasks;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class authManager : MonoBehaviour
{
    public Text logTxt;

    async void Start()
    {
        await UnityServices.InitializeAsync();
    }

    public async void Inloggen()
    {
        await anoniemInloggen();
    }

    async Task anoniemInloggen()
    {
        try
        {
            await AuthenticationService.Instance.SignInAnonymouslyAsync();

            print("Ingelogd!");
            print("Bewaar je Player ID goed!: " + AuthenticationService.Instance.PlayerId);
            logTxt.text = "inloggen... " + AuthenticationService.Instance.PlayerId; 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);       // Gaat naar MainMenu scene wanneer klaar
        }
        catch (AuthenticationException ex)
        {
            print("Inloggen niet gelukt!");
            Debug.LogException(ex);
        }
    }
}
