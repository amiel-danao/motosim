using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class PartsSelector : MonoBehaviour
{
    [SerializeField] private CinemachineFreeLook _cinemachineFreeLook;

    public void SetCameraTarget(Transform target){
        _cinemachineFreeLook.m_Follow = target;
        _cinemachineFreeLook.m_LookAt = target;
    }
}
