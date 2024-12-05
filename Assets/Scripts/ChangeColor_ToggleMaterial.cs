using UnityEngine;

public class ChangeColor_ToggleMaterial : MonoBehaviour
{
    [Header("Material Settings")]
    public Material materialOpaque;  // First material
    public Material materialTrans;  // Second material
    public Color blue;
    public Color white;

    private Renderer objectRenderer;
    private bool isWhite = true;  // To track which color is currently applied
    private bool isOpaque = true;  // To track which material is currently applied

    private void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        if (objectRenderer != null)
        {
            objectRenderer.material = materialOpaque;
            objectRenderer.material.color = white;
            isWhite = true;
            isOpaque = true;
        }
    }

    private void OnMouseDown()
    {
        // Toggle between the two colors
        if (objectRenderer != null)
        {
            if (isOpaque)
            {
                if (isWhite)
                {
                    objectRenderer.material.color = blue;
                }
                else
                {
                    objectRenderer.material.color = white;
                }

                isWhite = !isWhite; // Switch the color state
            }
        }
    }

    public void SwitchToggled()
    {
        // Toggle between the two materials
        if (objectRenderer != null)
        {
            if (isOpaque)
            {
                objectRenderer.material = materialTrans;
            }
            else
            {
                objectRenderer.material = materialOpaque;
            }

            isOpaque = !isOpaque;  // Switch the material state
        }
    }
}