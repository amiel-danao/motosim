using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ViolationUI : MonoBehaviour
{
    public static ViolationUI Instance;
    [SerializeField] private TMP_Text _violationTitle;
    [SerializeField] private TMP_Text _violationMessage;
    [SerializeField] private GameObject _violationParent;
    public event Action OnCloseViolation;
    public bool IsShown { get; private set; }

    public void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    internal void ShowViolation(Violation violation)
    {
        _violationTitle.SetText(violation.ViolationName);
        _violationMessage.SetText(violation.ViolationMessage);

        _violationParent.SetActive(true);
        IsShown = true;
    }

    public void CloseViolationWindow()
    {
        OnCloseViolation?.Invoke();
        Debug.Log("Pressed");
        _violationParent.SetActive(false);
        IsShown = false;
    }
}
