using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Services.CloudSave;
using UnityEngine.UI;
using Unity.Services.Core;

public class cloudSaveScript : MonoBehaviour
{
    public Text status;
    public InputField inpf;

    public async void Start()
    {
        await UnityServices.InitializeAsync();
    }

    public async void DataOpslaan()
    {
        var data = new Dictionary<string, object> {{"eerstedata",inpf.text}};
        await CloudSaveService.Instance.Data.ForceSaveAsync(data);
    }
}
