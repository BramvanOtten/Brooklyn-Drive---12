using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class waypointNavigatie : MonoBehaviour
{
    public Image Img;
    public Transform target;
    private void Update()
    {
        float minX = Img.GetPixelAdjustedRect().width / 2;
        float maxX = Screen.width - minX;

        float minY = Img.GetPixelAdjustedRect().width / 2;
        float maxY = Screen.width - minY;

        Vector2 pos = Camera.main.WorldToScreenPoint(target.position);

        if(Vector3.Dot((target.position - transform.position), transform.forward) < 0)
        {
            //wanneer de waypoint achter de player is
            if(pos.x < Screen.width / 2)
            {
                pos.x = maxX;
            }
            else
            {
                pos.x = minX;
            }
        }

        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);

        Img.transform.position = pos;
    }
}
