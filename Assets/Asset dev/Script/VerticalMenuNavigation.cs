using UnityEngine;
using UnityEngine.UI;

public class VerticalMenuNavigation : MonoBehaviour
{
    public Button[] buttons; // Array to hold references to the buttons
    public Button upArrow;   // Reference to the up arrow button
    public Button downArrow; // Reference to the down arrow button

    private int currentIndex = 0; // Index to track the current visible button

    void Start()
    {
        ShowButton(currentIndex);
        upArrow.onClick.AddListener(ShowPreviousButton);
        downArrow.onClick.AddListener(ShowNextButton);
    }

    private void ShowButton(int index)
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].gameObject.SetActive(i == index);
        }

        // Disable up/down arrows if at the top or bottom of the list
        upArrow.interactable = index > 0;
        downArrow.interactable = index < buttons.Length - 1;
    }

    public void ShowNextButton()
    {
        if (currentIndex < buttons.Length - 1)
        {
            currentIndex++;
            ShowButton(currentIndex);
        }
    }

    public void ShowPreviousButton()
    {
        if (currentIndex > 0)
        {
            currentIndex--;
            ShowButton(currentIndex);
        }
    }
}
