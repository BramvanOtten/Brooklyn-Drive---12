using System;
using System.IO;
using UnityEngine;

public class screenshotButton : MonoBehaviour
{
    // Update is called once per frame
    public void Update()
    {
        screenshotNemen();
    
    }

    void screenshotNemen()
    {
        // De path waar de screenshot naar opgeslagen word (documenten folder)
        string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string screenshotPath = Path.Combine(folderPath, "screenshot.png");

        // Neem de screenshot
        ScreenCapture.CaptureScreenshot(screenshotPath);

        // De path naar de console loggen
        Debug.Log("Screenshot genomen en opgeslagen naar: " + screenshotPath);
    }
}