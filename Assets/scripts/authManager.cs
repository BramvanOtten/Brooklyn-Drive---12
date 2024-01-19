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
            print("Dit is je player ID: " + AuthenticationService.Instance.PlayerId);     // Print automatisch aangemaakte player ID naar console 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);       // Gaat naar MainMenu scene wanneer klaar
        }
        catch (AuthenticationException ex)                                  // Als het niet goed gaat, error message
        {
            print("Inloggen niet gelukt!");
            Debug.LogException(ex);
        }
    }
}
