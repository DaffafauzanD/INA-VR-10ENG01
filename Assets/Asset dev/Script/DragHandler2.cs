using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler2 : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Vector3 startPosition;
    private Transform startParent;

    public void OnBeginDrag(PointerEventData eventData)
    {
        startPosition = transform.position;
        startParent = transform.parent;
        GetComponent<CanvasGroup>().blocksRaycasts = false; // Make it transparent to raycasts
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        GetComponent<CanvasGroup>().blocksRaycasts = true; // Restore raycast blocking

        if (transform.parent == startParent)
        {
            transform.position = startPosition; // If not dropped into a new cell, return to start
        }
    }
}
