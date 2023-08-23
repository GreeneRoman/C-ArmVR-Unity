using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveAperfect : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public Vector3 targetPosition = new Vector3(2.2f, 0, 0); // The position you want to move to

    private bool isMoving = false;




    private void Update()
    {
        // Calculate the movement direction
        Vector3 movementDirection = (targetPosition - transform.position).normalized;

        // Calculate the new position based on speed and time
        Vector3 newPosition = transform.position + movementDirection * moveSpeed * Time.deltaTime;

        // Check if the distance between the current position and target position is small
        if (Vector3.Distance(transform.position, targetPosition) <= moveSpeed * Time.deltaTime)
        {
            newPosition = targetPosition; // Ensure exact target position
        }

        // Update the object's position
        transform.position = newPosition;
    }
}

    // void Update()
    // {
    //   if (Input.GetKeyDown(KeyCode.V) && !isMoving) // Change to the "V" key
    //    {
    //  isMoving = true;
    //   }

    //  if (isMoving)
    //  {
    // Calculate the movement direction
    //     Vector3 movementDirection = (targetPosition - transform.position).normalized;

    // Calculate the new position based on input and speed
    //     Vector3 newPosition = transform.position + movementDirection * moveSpeed * Time.deltaTime;

    // Check if we've reached the target position
    //    if (Vector3.Distance(transform.position, targetPosition) <= 0.01f)
    //    {
    //  isMoving = false; // Stop moving
    //        newPosition = targetPosition; // Ensure exact target position
    //   }

    // Update the object's position
    //   transform.position = newPosition;
    // }
    //   }
