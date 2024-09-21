using UnityEngine;
using UnityEngine.UI;

public class VerticalSwipeMenu : MonoBehaviour
{
    public Button[] buttons; // Array to hold references to the buttons
    private int currentIndex = 0; // Index to track the current visible button

    void Start()
    {
        ShowButton(currentIndex);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            ShowPreviousButton();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            ShowNextButton();
        }
    }

    private void ShowButton(int index)
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].gameObject.SetActive(i == index);
        }
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
