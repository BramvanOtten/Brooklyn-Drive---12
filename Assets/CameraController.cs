using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    float rotationX = 0f;
    float rotationY = 0f;

    public float sensitvity = 15f;

    // Update is called once per frame
    void Update()
    {
        rotationY += Input.GetAxis("Mouse X") * sensitvity;
        rotationX += Input.GetAxis("Mouse Y") * -1 * sensitvity;
        transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
    }
}
