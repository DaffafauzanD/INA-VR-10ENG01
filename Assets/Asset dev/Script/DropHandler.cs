using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropHandler : MonoBehaviour, IDropHandler
{
    public TextMeshProUGUI targetText; // TextMeshProUGUI di dalam cell kosong (panel)

    public void OnDrop(PointerEventData eventData)
    {
        GameObject droppedObject = eventData.pointerDrag; // Objek yang di-drag
        if (droppedObject != null)
        {
            // Dapatkan komponen TextMeshProUGUI dari objek yang di-drag
            TextMeshProUGUI droppedText = droppedObject.GetComponentInChildren<TextMeshProUGUI>();

            if (droppedText != null)
            {
                // Debug log untuk memastikan teks yang diambil
                Debug.Log("Dropped text: " + droppedText.text);

                // Set teks di cell kosong dengan teks dari objek yang di-drag
                targetText.text = droppedText.text;

                // Menghilangkan objek yang di-drag
                Destroy(droppedObject);

                Debug.Log("Text replaced successfully!");
            }
            else
            {
                Debug.LogError("Dropped object does not contain a TextMeshProUGUI component.");
            }
        }
    }
}
