using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class SwipeMenu : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public RectTransform content;
    private Vector2 startPosition;
    public float snapSpeed = 10f;

    private int totalPages;
    private int currentPage = 0;

    private void Start()
    {
        totalPages = content.childCount;
    }

    public void OnDrag(PointerEventData eventData)
    {
        content.anchoredPosition += new Vector2(eventData.delta.x, 0);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        float nearestPage = Mathf.Round(content.anchoredPosition.x / Screen.width) * Screen.width;
        nearestPage = Mathf.Clamp(nearestPage, -Screen.width * (totalPages - 1), 0);

        currentPage = Mathf.RoundToInt(nearestPage / -Screen.width);
        StartCoroutine(SmoothSnap(nearestPage));
    }

    private IEnumerator SmoothSnap(float targetPosition)
    {
        while (Mathf.Abs(content.anchoredPosition.x - targetPosition) > 0.1f)
        {
            content.anchoredPosition = Vector2.Lerp(content.anchoredPosition, new Vector2(targetPosition, content.anchoredPosition.y), snapSpeed * Time.deltaTime);
            yield return null;
        }

        content.anchoredPosition = new Vector2(targetPosition, content.anchoredPosition.y);
    }
}
