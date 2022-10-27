using System.Collections;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public void Awake()
    {
        Invoke(nameof(DisAppear), 3f);
    }

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime, Space.World);
        transform.LookAt(CameraControllerV2.CameraInstance.transform);
    }

    private void DisAppear()
    {
        Destroy(gameObject);
    }

}