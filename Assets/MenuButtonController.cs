using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButtonController : MonoBehaviour
{
    public Button listeningButton;
    public Button readingButton;
    public Button writingButton;
    public Button speakingButton;

    // Start is called before the first frame update
    void Start()
    {
        // At the start, only Listening is interactable
        listeningButton.interactable = true;
        readingButton.interactable = false;
        writingButton.interactable = false;
        speakingButton.interactable = false;

        // Check PlayerPrefs to unlock the buttons based on user progress
        if (PlayerPrefs.GetInt("ReadingUnlocked", 0) == 1)
        {
            readingButton.interactable = true;
        }

        if (PlayerPrefs.GetInt("WritingUnlocked", 0) == 1)
        {
            writingButton.interactable = true;
        }

        if (PlayerPrefs.GetInt("SpeakingUnlocked", 0) == 1)
        {
            speakingButton.interactable = true;
        }
    }

    // Call this method when the user completes Listening
    public void OnListeningCompleted()
    {
        // Unlock the Reading button and save progress
        readingButton.interactable = true;
        PlayerPrefs.SetInt("ReadingUnlocked", 1);
    }

    // Call this method when the user completes Reading
    public void OnReadingCompleted()
    {
        // Unlock the Writing button and save progress
        writingButton.interactable = true;
        PlayerPrefs.SetInt("WritingUnlocked", 1);
    }

    // Call this method when the user completes Writing
    public void OnWritingCompleted()
    {
        // Unlock the Speaking button and save progress
        speakingButton.interactable = true;
        PlayerPrefs.SetInt("SpeakingUnlocked", 1);
    }

    // Example of how you might trigger the completion when entering a new scene
    public void OnEnterListeningScene()
    {
        // Load the Listening scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("ListeningScene");
    }
}
