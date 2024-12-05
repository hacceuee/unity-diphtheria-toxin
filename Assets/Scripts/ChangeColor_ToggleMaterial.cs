using UnityEngine;

public class ChangeColor_ToggleMaterial : MonoBehaviour
{
    [Header("Material Settings")]
<<<<<<< Updated upstream:Assets/Scripts/ToggleMaterial.cs
    public Material materialOne;  // First material
    public Material materialTwo;  // Second material
=======
    public Material materialOpaque;  // First material
    public Material materialTrans;  // Second material
    public Color highlightedColor;
    public Color defaultColor; 
>>>>>>> Stashed changes:Assets/Scripts/ChangeColor_ToggleMaterial.cs

    private Renderer objectRenderer;
    private bool isMaterialOne = true;  // To track which material is currently applied

    private void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        if (objectRenderer != null)
        {
<<<<<<< Updated upstream:Assets/Scripts/ToggleMaterial.cs
            objectRenderer.material = materialOne;  // Set initial material
=======
            objectRenderer.material = materialOpaque;
            objectRenderer.material.color = defaultColor;
            isWhite = true;
            isOpaque = true; 
>>>>>>> Stashed changes:Assets/Scripts/ChangeColor_ToggleMaterial.cs
        }
    }

    private void OnMouseDown()
    {
<<<<<<< Updated upstream:Assets/Scripts/ToggleMaterial.cs
=======
        // Toggle between the two colors
        if (objectRenderer != null)
        {
            if (isOpaque)
            {
                if (isWhite)
                {                   
                    objectRenderer.material.color = highlightedColor;
                }
                else
                {
                    objectRenderer.material.color = defaultColor;
                }

                isWhite = !isWhite; // Switch the color state
            }
        }
    }

    public void SwitchToggled()
    {
>>>>>>> Stashed changes:Assets/Scripts/ChangeColor_ToggleMaterial.cs
        // Toggle between the two materials
        if (objectRenderer != null)
        {
            if (isMaterialOne)
            {
<<<<<<< Updated upstream:Assets/Scripts/ToggleMaterial.cs
                objectRenderer.material = materialTwo;
            }
            else
            {
                objectRenderer.material = materialOne;
=======
                objectRenderer.material = materialTrans;
            }
            else
            {
                objectRenderer.material = materialOpaque;
>>>>>>> Stashed changes:Assets/Scripts/ChangeColor_ToggleMaterial.cs
            }

            isMaterialOne = !isMaterialOne;  // Switch the material state
        }
    }
}
