using UnityEngine;

public class ToggleMaterial : MonoBehaviour
{
    [Header("Material Settings")]
    public Material materialOne;  // First material
    public Material materialTwo;  // Second material

    private Renderer objectRenderer;
    private bool isMaterialOne = true;  // To track which material is currently applied

    private void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        if (objectRenderer != null)
        {
            objectRenderer.material = materialOne;  // Set initial material
        }
    }

    private void OnMouseDown()
    {
        // Toggle between the two materials
        if (objectRenderer != null)
        {
            if (isMaterialOne)
            {
                objectRenderer.material = materialTwo;
            }
            else
            {
                objectRenderer.material = materialOne;
            }

            isMaterialOne = !isMaterialOne;  // Switch the material state
        }
    }
}
