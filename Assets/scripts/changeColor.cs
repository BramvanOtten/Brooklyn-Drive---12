using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public GameObject newButton;

    void Start()
    {
        // Laad de kleur van de PlayerPref wanneer de scene start
        kleurLaden();
    }

    public void kleurVeranderen()
    {
        newButton.GetComponent<Image>().color = Color.green;

        // Sla de kleur op in de PlayerPref
        kleurOpslaan();
    }

    private void kleurOpslaan()
{
    Color buttonColor = newButton.GetComponent<Image>().color;
    string colorHex = ColorUtility.ToHtmlStringRGB(buttonColor);
    Debug.Log("Kleur opslaan: " + colorHex);

    PlayerPrefs.SetString("ButtonColor", colorHex);
    PlayerPrefs.Save();
    Debug.Log("Kleur opgeslagen: " + colorHex);
}

    private void kleurLaden()
{
    // Check of de kleur bestaat in de PlayerPref
    if (PlayerPrefs.HasKey("ButtonColor"))
    {
        newButton.GetComponent<Image>().color = Color.green;
    }
    else
    {
        Debug.Log("Geen opgeslagen kleur gevonden.");
    }
}
}