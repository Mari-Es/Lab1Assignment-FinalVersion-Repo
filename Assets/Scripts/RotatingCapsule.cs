using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingCapsule : MonoBehaviour
{
    public float rotationSpeed = 90f;  // Rotation speed in degrees per second


    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime); //Vector3.up rotates the object around the Y-axis.
        }
    }
}
