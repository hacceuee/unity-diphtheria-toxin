using UnityEngine;

public class AssignCamera : MonoBehaviour
{
    private void Start()
    {
        Canvas canvas = GetComponent<Canvas>();

        if (canvas != null)
        {
            if (Camera.main != null)
            {
                canvas.worldCamera = Camera.main;
                Debug.Log("Event Camera assigned to: " + Camera.main.name);
            }
            else
            {
                Debug.LogWarning("No Main Camera found in the scene!");
            }
        }
        else
        {
            Debug.LogError("Canvas component not found on this GameObject.");
        }
    }
}