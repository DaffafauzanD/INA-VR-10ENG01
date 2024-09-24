using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class GameObjectEvent : UnityEvent<GameObject> { }

public class DraggableUISlot : MonoBehaviour
{
    public GameObjectEvent OnDroppedWithObject;

    public void OnDrop(GameObject droppedObject)
    {
        droppedObject.transform.SetParent(transform);
        droppedObject.transform.position = transform.position;

        OnDroppedWithObject?.Invoke(droppedObject);

        Debug.Log("Object dropped into slot: " + droppedObject.name);
    }
}
