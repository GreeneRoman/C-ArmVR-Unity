using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pos_one_AB : MonoBehaviour
{
    public float rotationSpeed = 45.0f; // Rotation speed in degrees per second
    public Vector3 initialRotationEulerFirst = new Vector3(0, 0, 0); // Initial rotation for the first object in Euler angles
    public Vector3 initialRotationEulerSecond = new Vector3(0, 0, 0); // Initial rotation for the second object in Euler angles

    private Quaternion targetRotationFirst; // The target rotation for the first object in Quaternion format
    private Quaternion targetRotationSecond; // The target rotation for the second object in Quaternion format

    private bool rotateFirstObject = false;
    private bool rotateSecondObject = false;

    public GameObject firstObject;
    public GameObject secondObject;

    private void Start()
    {
        targetRotationFirst = Quaternion.Euler(initialRotationEulerFirst);
        targetRotationSecond = Quaternion.Euler(initialRotationEulerSecond);
    }

    private void Update()
    {
        if (rotateFirstObject)
        {
            float rotationStep = rotationSpeed * Time.deltaTime;

            firstObject.transform.rotation = Quaternion.RotateTowards(firstObject.transform.rotation, targetRotationFirst, rotationStep);

            if (Quaternion.Angle(firstObject.transform.rotation, targetRotationFirst) < 0.1f)
            {
                rotateFirstObject = false;
                rotateSecondObject = true;
            }
        }

        if (rotateSecondObject)
        {
            float rotationStep = rotationSpeed * Time.deltaTime;

            secondObject.transform.rotation = Quaternion.RotateTowards(secondObject.transform.rotation, targetRotationSecond, rotationStep);
        }
    }

    public void StartRotation()
    {
        rotateFirstObject = true;
    }
}