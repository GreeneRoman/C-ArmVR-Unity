using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tabtilt : MonoBehaviour

{

    public Vector3 rotationAxis = Vector3.up; // Axis around which to rotate
    public float targetRotationAngle = 90.0f; // Desired rotation angle in degrees
    public float rotationSpeed = 45.0f; // Rotation speed in degrees per second

    private float currentRotationAngle = 0.0f; // Current rotation angle achieved

    private void Update()
    {
        // Calculate the rotation amount based on time and speed
        float rotationAmount = rotationSpeed * Time.deltaTime;

        // Rotate the object around the specified axis
        transform.Rotate(rotationAxis, rotationAmount);

        // Update the current rotation angle
        currentRotationAngle += rotationAmount;

        // Check if the desired rotation angle is achieved
        if (currentRotationAngle >= targetRotationAngle)
        {
            // Correct rotation overshoot
            float overshoot = currentRotationAngle - targetRotationAngle;
            transform.Rotate(rotationAxis, -overshoot);

            // Disable the script to stop further rotation
            enabled = false;
        }
    }
}