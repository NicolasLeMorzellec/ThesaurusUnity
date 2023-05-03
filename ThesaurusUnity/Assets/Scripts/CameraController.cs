using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController  : MonoBehaviour
{
    public float moveSpeed = 10f; // the speed at which the camera moves
    public float turnSpeed = 50f; // the speed at which the camera turns

    void Update()
    {
        // move the camera forwards or backwards based on the up/down arrow keys
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * moveSpeed * Time.deltaTime);

        // rotate the camera left or right based on the left/right arrow keys
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime);
    }
}