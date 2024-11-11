using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    Vector3 mPrevPos = Vector3.zero;
    Vector3 mPosDelta = Vector3.zero;
    private Vector3 mouseWorldPosStart;

    private Vector3 offset;
    private Vector3 screenPoint;

    public float rotationSpeed = 10f; // Maximum speed of rotation
    public float rotationAcceleration = 2f; // Acceleration factor when the mouse is released
    private float currentRotationSpeed = 0f; // Current rotation speed (starts at 0)

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && !Input.GetKey(KeyCode.LeftControl))
        {
            CamOrb();
        }

        if (Input.GetMouseButtonDown(0) && Input.GetKey(KeyCode.LeftControl))
        {
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        }
        if (Input.GetMouseButton(0) && Input.GetKey(KeyCode.LeftControl))
        {
            Pan();
        }
        
        if (!Input.GetMouseButton(0))
        {
            GentleRotate();
        }
    }

    private void Pan()
    {
        if (Input.GetAxis("Mouse Y") != 0 || Input.GetAxis("Mouse X") != 0)
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            transform.position = curPosition;
        }
    }

    private void CamOrb()
    {

        if (!Input.GetKey(KeyCode.LeftControl) && Input.GetMouseButtonDown(0))
        {
            mPrevPos = Input.mousePosition;
            //Debug.Log("right clicked");
        }
        if (Input.GetAxis("Mouse Y") != 0 || Input.GetAxis("Mouse X") != 0)
        {
            mPosDelta = Input.mousePosition - mPrevPos;
            //Debug.Log("holding button");
            if (Vector3.Dot(transform.up, Vector3.up) >= 0)
            {
                transform.Rotate(transform.up, -Vector3.Dot(mPosDelta, Camera.main.transform.right), Space.World);
            }
            else
            {
                transform.Rotate(transform.up, Vector3.Dot(mPosDelta, Camera.main.transform.right), Space.World);
            }
            transform.Rotate(Camera.main.transform.right, Vector3.Dot(mPosDelta, Camera.main.transform.up), Space.World);
            mPrevPos = Input.mousePosition;
        }
    }

    private void GentleRotate()
    { }
        // Gradually increase rotation speed after mouse release
        if (currentRotationSpeed < rotationSpeed)
        {
            currentRotationSpeed = Mathf.Lerp(currentRotationSpeed, rotationSpeed, rotationAcceleration * Time.deltaTime);
        }

        // Apply the gentle rotation
        transform.Rotate(Vector3.up, currentRotationSpeed * Time.deltaTime);
    }

}
