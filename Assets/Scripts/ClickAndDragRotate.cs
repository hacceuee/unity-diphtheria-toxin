using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAndDragRotate : MonoBehaviour
{
    public float rotationSpeed = 5.0f; // Adjust this value to change the rotation sensitivity

    private Vector3 lastMousePosition;

    void Update()
    {
        // Check if the mouse button is being held down
        if (Input.GetMouseButton(0))
        {
            // Calculate mouse movement
            Vector3 mouseDelta = Input.mousePosition - lastMousePosition;

            // Rotate the object around its Y axis for horizontal drag
            transform.Rotate(Vector3.up, -mouseDelta.x * rotationSpeed * Time.deltaTime, Space.World);

            // Rotate the object around its X axis for vertical drag
            transform.Rotate(Vector3.right, mouseDelta.y * rotationSpeed * Time.deltaTime, Space.Self);
        }

        // Update the last mouse position for the next frame
        lastMousePosition = Input.mousePosition;
    }
    }
