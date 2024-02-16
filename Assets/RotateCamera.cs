using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    [SerializeField] private float angle = 1.0f;

    void FixedUpdate()
    {
        transform.Rotate(0.0f, angle, 0.0f);
    }
}
