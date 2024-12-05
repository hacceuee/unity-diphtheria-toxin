using UnityEngine;

public class ChangeDifferentObjectMaterial : MonoBehaviour
{
    [Header("Material Settings")]
    public Material materialOne;  // First material
    public Material materialTwo;  // Second material

    [Header("Target Object")]
    public GameObject targetObject;  // The object whose material will be changed

    private Renderer targetRenderer;
    private bool isMaterialOne = true;  // To track which material is currently applied on the target object

    private void Start()
    {
        if (targetObject != null)
        {
            targetRenderer = targetObject.GetComponent<Renderer>();
            if (targetRenderer != null)
            {
                targetRenderer.material = materialOne;  // Set the initial material on the target object
            }
        }
    }

    private void OnMouseDown()
    {
        // Check if the targetRenderer is available
        if (targetRenderer != null)
        {
            // Toggle between the two materials on the target object
            if (isMaterialOne)
            {
                targetRenderer.material = materialTwo;
            }
            else
            {
                targetRenderer.material = materialOne;
            }

            isMaterialOne = !isMaterialOne;  // Switch the material state
        }
    }
}