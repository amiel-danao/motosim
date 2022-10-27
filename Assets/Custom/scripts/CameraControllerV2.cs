using System.Collections;
using UnityEngine;


public class CameraControllerV2 : MonoBehaviour
{
    public static Camera CameraInstance;
    // Use this for initialization
    void Awake()
    {
        CameraInstance = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}