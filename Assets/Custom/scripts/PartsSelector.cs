using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class PartsSelector : MonoBehaviour
{
    [SerializeField] private CinemachineFreeLook _cinemachineFreeLook;
    [SerializeField] private Outline[] _outlines; 

    private void Start(){
        ToggleOutlines(false);
        _outlines[0].enabled = true;
    }

    public void SetCameraTarget(Transform target){
        _cinemachineFreeLook.m_Follow = target;
        _cinemachineFreeLook.m_LookAt = target;
    }

    public void ToggleOutlines(bool isOn){
        foreach(var outline in _outlines){
            outline.enabled = isOn;
        }
    }
}
