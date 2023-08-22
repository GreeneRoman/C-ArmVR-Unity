using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tab_movement : MonoBehaviour
{

    public GameObject tb;
    public float mov_speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.U))
        {

            MoveObject();

        }

       // if (Input.GetKey(KeyCode.J))
       // {
        //    MoveObjectD();
       // }
    }


    void MoveObject()
    {
        // Get the current position of the object
        Vector3 currentPosition = transform.position;

        // Example: Move the object forward along the Z-axis
        // You can modify the values here to move the object in different directions or distances
        currentPosition += transform.forward * mov_speed * Time.deltaTime;

        // Update the object's position
        transform.position = currentPosition;
    }



   // void MoveObjectD()
   // {

     //  Vector3 currentPosition = transform.position;

        //
       // currentPosition += transform.down * mov_speed * Time.deltaTime;

        
     //   transform.position = currentPosition;
   // }
}
