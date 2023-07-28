using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject targetObject;
    public float rotationSpeed = 45f;
    void Start()
    {
       

        
    }

    // Update is called once per frame
    void Update()
    {
        




        if (Input.GetKey(KeyCode.W))
        {
            float xRotation = GetObjectRotation(transform.eulerAngles.x); 
            Debug.Log("X For W ->" + xRotation);
            if (xRotation < -30f) {
                return;
            }
            transform.RotateAround(transform.position, transform.right, -(Time.deltaTime * 90));
            targetObject.transform.Rotate(Vector3.right * rotationSpeed * -(Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.A))
        {
            float xRotation = GetObjectRotation(transform.eulerAngles.z);
            Debug.Log("Z For A ->" + xRotation);
            if (xRotation < -30f)
            {
                return;
            }
            transform.RotateAround(transform.position, transform.forward, -(Time.deltaTime * 90));
           // targetObject.transform.Rotate(Vector3.forward * rotationSpeed *-( Time.deltaTime * 90));
        }

        if (Input.GetKey(KeyCode.S))
        {
            float xRotation = GetObjectRotation(transform.eulerAngles.x);
            Debug.Log("X For S ->" + xRotation);
            if (xRotation > 30f)
            {
                return;
            }
            transform.RotateAround(transform.position, transform.right, (Time.deltaTime * 90));
           // targetObject.transform.Rotate(Vector3.right * rotationSpeed * (Time.deltaTime * 90));
        }

        if (Input.GetKey(KeyCode.D))
        {
            float xRotation = GetObjectRotation(transform.eulerAngles.z);
            Debug.Log("Z For D ->" + xRotation);
            if (xRotation > 30f)
            {
                return;
            }
            transform.RotateAround(transform.position, transform.forward, Time.deltaTime * 90);
           // targetObject.transform.Rotate(Vector3.forward * rotationSpeed * (Time.deltaTime *90));
        }
    }

    float GetObjectRotation(float rotationValue)
    {
        if (rotationValue > 180f)
        {
            return rotationValue - 360;
        }
        else
        {
            return rotationValue;
        }
    }
}
