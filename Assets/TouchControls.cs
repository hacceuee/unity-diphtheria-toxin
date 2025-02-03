using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;

public class TouchControls : MonoBehaviour
{
    private Camera cam;
    private Vector2 previousTouchPosition;
    private float minZoom = 20f;
    private float maxZoom = 100f;
    private float rotationSpeed = 0.2f;
    private float zoomSpeed = 0.01f;

    private void Awake()
    {
        cam = Camera.main;
        EnhancedTouchSupport.Enable(); // Enables Unity's new touch system
    }

    private void Update()
    {
        var activeTouches = UnityEngine.InputSystem.EnhancedTouch.Touch.activeTouches;

        if (activeTouches.Count == 1)
        {
            HandleRotation(activeTouches[0]);
        }
        else if (activeTouches.Count == 2)
        {
            HandlePinchZoom(activeTouches[0], activeTouches[1]);
        }
    }

    private void HandleRotation(UnityEngine.InputSystem.EnhancedTouch.Touch touch)
    {
        if (touch.phase == UnityEngine.InputSystem.TouchPhase.Began)
        {
            previousTouchPosition = touch.screenPosition;
        }
        else if (touch.phase == UnityEngine.InputSystem.TouchPhase.Moved)
        {
            Vector2 touchDelta = touch.screenPosition - previousTouchPosition;

            float horizontalRotation = touchDelta.x * rotationSpeed;
            float verticalRotation = touchDelta.y * rotationSpeed;

            transform.Rotate(Vector3.up, -horizontalRotation, Space.World);
            transform.Rotate(transform.right, verticalRotation, Space.World);

            previousTouchPosition = touch.screenPosition;
        }
    }

    private void HandlePinchZoom(UnityEngine.InputSystem.EnhancedTouch.Touch touch0, UnityEngine.InputSystem.EnhancedTouch.Touch touch1)
    {
        float prevDistance = (touch0.startScreenPosition - touch1.startScreenPosition).magnitude;
        float currentDistance = (touch0.screenPosition - touch1.screenPosition).magnitude;

        float difference = currentDistance - prevDistance;
        CameraZoom(-difference * zoomSpeed);
    }

    private void CameraZoom(float increment)
    {
        cam.fieldOfView = Mathf.Clamp(cam.fieldOfView + increment, minZoom, maxZoom);
    }
}
