using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Vector3 startPosition;
    private Transform parentToReturnTo = null;

    public void OnBeginDrag(PointerEventData eventData)
    {
        startPosition = this.transform.position;
        parentToReturnTo = this.transform.parent;
        this.transform.SetParent(this.transform.root); // Move it to top level in hierarchy
    }

    public void OnDrag(PointerEventData eventData)
    {
        // Mengambil posisi mouse dari New Input System
        Vector2 mousePosition = Mouse.current.position.ReadValue();

        // Menggunakan mousePosition untuk logika drag
        Debug.Log("Mouse Position: " + mousePosition);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        this.transform.SetParent(parentToReturnTo);
        this.transform.position = startPosition;
    }
}
