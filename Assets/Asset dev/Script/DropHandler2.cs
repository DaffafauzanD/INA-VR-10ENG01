using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class DropHandler2 : MonoBehaviour, IDropHandler
{
    public string correctAnswer;

    public void OnDrop(PointerEventData eventData)
    {
        GameObject droppedObject = eventData.pointerDrag;

        if (droppedObject != null)
        {
            string droppedText = droppedObject.GetComponentInChildren<TextMeshProUGUI>().text;

            if (droppedText == correctAnswer)
            {
                droppedObject.transform.SetParent(this.transform);
                droppedObject.GetComponent<RectTransform>().anchoredPosition = Vector3.zero;
                Debug.Log("Correct word placed!");
            }
            else
            {
                Debug.Log("Incorrect word.");
            }
        }
    }

}
