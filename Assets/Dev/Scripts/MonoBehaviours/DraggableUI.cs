using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class DraggableUI : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [HideInInspector] public Transform parentAfterDrag;
    [SerializeField] private DraggableUISlotManager slotManager;
    Image image;

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Dragging");
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
        //GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging");
        if (eventData.pointerCurrentRaycast.isValid)
        {
            var currentRaycastPosition = eventData.pointerCurrentRaycast.worldPosition;
            transform.position = currentRaycastPosition;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Transform closestSlot = slotManager.GetClosestSlot(transform.position);
        DraggableUISlot slot = closestSlot.GetComponent<DraggableUISlot>();

        if (slot != null)
        {
            if (slot.transform.childCount == 0)
            {
                parentAfterDrag = closestSlot;
                transform.SetParent(parentAfterDrag);
                transform.position = parentAfterDrag.position;
                slot.OnDrop(gameObject);
            }
            else
            {
                Debug.Log("Slot already occupied!");
                transform.SetParent(parentAfterDrag);
                transform.position = parentAfterDrag.position;
            }
        }

        Debug.Log("Dropped on closest slot: " + parentAfterDrag.name);
        image.raycastTarget = true;
        //GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}