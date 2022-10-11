using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class InGameViolation : MonoBehaviour
{
    private Collider _collider;
    [SerializeField] protected Violation _violation;
    protected float _nextViolationTimeOffset = 1f;

    private void Awake()
    {
        _collider = GetComponent<Collider>();
    }

    private void Update()
    {
        _nextViolationTimeOffset -= 0.1f * Time.deltaTime;
    }



    public virtual void Violate()
    {
        if (_nextViolationTimeOffset <= 0f)
        {
            ViolationUI.Instance.ShowViolation(_violation);
            Time.timeScale = 0f;
            _nextViolationTimeOffset = 1f;
        }
    }
}
