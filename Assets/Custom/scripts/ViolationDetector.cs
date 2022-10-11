using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class ViolationDetector : MonoBehaviour
{
    private List<InGameViolation> _currentTriggers;

    private void Awake()
    {
        _currentTriggers = new List<InGameViolation>();
    }

    private void Start()
    {
        ViolationUI.Instance.OnCloseViolation += Resume;
    }
    private void Resume()
    {
        Time.timeScale = 1f;
        Debug.Log("Resume");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.TryGetComponent(out InGameViolation inGameViolation))
        {
            inGameViolation.Violate();
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (ViolationUI.Instance.IsShown)
            return;
        if (collision.collider.TryGetComponent(out InGameViolation inGameViolation))
        {
            inGameViolation.Violate();
        }
    }

    private void OnTriggerEnter(Collider other)
    {

    }

    private void OnTriggerExit(Collider other)
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (ViolationUI.Instance.IsShown)
            return;
        if (other.TryGetComponent(out InGameViolation inGameViolation))
        {
            inGameViolation.Violate();
        }
    }
}
