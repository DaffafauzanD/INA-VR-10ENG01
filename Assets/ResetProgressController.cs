using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetProgressController : MonoBehaviour
{
    public Button resetButton;

    void Start()
    {
        // Ensure the button is assigned
        if (resetButton != null)
        {
            resetButton.onClick.AddListener(ResetAllProgress);
        }
    }

    // Method to reset all player progress
    public void ResetAllProgress()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save(); // Ensure the changes are written to disk
        Debug.Log("All player progress has been reset.");
    } 
}
