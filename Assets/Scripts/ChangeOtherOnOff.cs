using UnityEngine;

public class ChangeOtherOnOff : MonoBehaviour
{
    public GameObject[] targetObjects;  // Array of objects whose visibility will be toggled

    private void Start()
    {
        // Ensure all target objects are active by default
        foreach (var obj in targetObjects)
        {
            if (obj != null)
            {
                obj.SetActive(true);  // Set the initial state of each target object to active
            }
        }
    }

    private void OnMouseDown()
    {
        // Check if the array is not empty
        if (targetObjects != null)
        {
            // Toggle the active state of each target object in the array
            foreach (var obj in targetObjects)
            {
                if (obj != null)
                {
                    obj.SetActive(!obj.activeSelf);  // Toggle visibility
                }
            }
        }
    }
}