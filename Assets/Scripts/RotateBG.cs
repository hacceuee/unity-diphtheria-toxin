using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBG : MonoBehaviour
{ 

    // Rotation settings
    public float rotationSpeed = 10f;
    public float rotationAcceleration = 2f;
    private float currentRotationSpeed = 0f;

    // Gentle spin cooldown settings
    public float rotationCooldownDuration = 0.5f; // Duration of the pause after mouse release (in seconds)
    private float rotationCooldown = 0f; // Timer for the cooldown

    private void Start()
    {
    }

    private void Update()
    {
        ApplyGentleRotation();
    }

    // Applies a gentle automatic rotation with a cooldown delay after mouse release
    private void ApplyGentleRotation()
    {
        // Decrease the cooldown timer if it's greater than 0
        if (rotationCooldown > 0)
        {
            rotationCooldown -= Time.deltaTime;
            return; // Pause gentle rotation until cooldown is over
        }

        // Gradually increase rotation speed after cooldown
        if (currentRotationSpeed < rotationSpeed)
        {
            currentRotationSpeed = Mathf.Lerp(currentRotationSpeed, rotationSpeed, rotationAcceleration * Time.deltaTime);
        }

        // Apply the gentle rotation
        transform.Rotate(Vector3.up, currentRotationSpeed * Time.deltaTime);
    }
}

