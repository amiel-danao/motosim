using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Road : MonoBehaviour
{
    public Collider MyCollider { get; private set; }

    private void Awake()
    {
        MyCollider = GetComponent<Collider>();
    }
}
