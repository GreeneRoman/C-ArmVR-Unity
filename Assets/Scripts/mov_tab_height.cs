using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov_tab_height : MonoBehaviour
{

    public Vector3 targetOffset = new Vector3(0, 0, 0); // Target position offset from the initial position
    public float moveDuration = 2.0f; // Time taken to move to the target position

    private Vector3 initialPosition; // Initial position of the object
    private Vector3 targetPosition; // Calculated target position

    private float elapsedTime = 0.0f; // Time elapsed since movement started

    private void Start()
    {
        initialPosition = transform.position;
        targetPosition = initialPosition + targetOffset;
    }

    private void Update()
    {
        // Increment the elapsed time
        elapsedTime += Time.deltaTime;

        // Calculate the percentage of completion
        float percentageComplete = elapsedTime / moveDuration;

        // Calculate the new position using Lerp
        Vector3 newPosition = Vector3.Lerp(initialPosition, targetPosition, percentageComplete);

        // Update the object's position
        transform.position = newPosition;

        // If movement is complete, reset variables and stop movement
        if (percentageComplete >= 1.0f)
        {
            elapsedTime = 0.0f;
            initialPosition = targetPosition;
            targetPosition = initialPosition + targetOffset;

            enabled = false; // Disable the script to stop further movement
        }
    }
}





