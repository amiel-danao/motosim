using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ScrollZoom : MonoBehaviour
{
    public float zoomSpeed = 10f;
    public float minZoom = 10f;
    public float maxZoom = 100f;

    public CinemachineFollowZoom zoomCamera;

    void Update()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        
        float newZoom = zoomCamera.m_MaxFOV - scroll * zoomSpeed;

        if (newZoom > maxZoom)
        {
            newZoom = maxZoom;
        }
        else if (newZoom < minZoom)
        {
            newZoom = minZoom;
        }

        zoomCamera.m_MaxFOV = newZoom;
        zoomCamera.m_MinFOV = newZoom;
    }
}
