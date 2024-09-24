using UnityEngine;
using System.Collections.Generic;

public class DraggableUISlotManager : MonoBehaviour
{
    public List<Transform> gridElements;

    private void Start()
    {
        // Initialize gridElements list if it's not manually populated in the inspector
        if (gridElements == null || gridElements.Count == 0)
        {
            gridElements = new List<Transform>();

            // Automatically find child grid slots, excluding the parent container itself
            foreach (Transform child in transform)
            {
                if (child != transform) // Ensure the parent container itself is not included
                {
                    gridElements.Add(child); // Add only the actual grid cells (child elements)
                }
            }
        }
    }

    public Transform GetClosestSlot(Vector3 objectPosition)
    {
        Transform closestSlot = null;
        float closestDistance = Mathf.Infinity;

        foreach (Transform slot in gridElements)
        {
            float distance = Vector3.Distance(objectPosition, slot.position);
            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestSlot = slot;
            }
        }

        return closestSlot;
    }
}
