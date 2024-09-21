using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;



public class ScriptQuizTap : MonoBehaviour
{

    // List of all toggles (10 in total)
    public List<Toggle> toggles;
    public GameObject ShowTextCorrect;
    public GameObject ShowTextIncorrect;
    public GameObject ButtonShow;
    public GameObject QuizAnswer;
  


    // Indices of correct toggles (6 correct answers)
    private List<int> correctToggles = new List<int> { 0, 1, 3, 4, 6, 8 }; // Fanatic, Boring, Sporty, Play, Athletic, Motivating

    // Text to display feedback
    // public Text feedbackText;

    private int failcount = 0;

    // Function that will be called when button is clicked
    public void CheckAnswers()
    {
        // Counter to track correct toggles selected
        int correctCount = 0;

        // Check if all correct toggles are selected and no extra is selected
        for (int i = 0; i < toggles.Count; i++)
        {
            if (correctToggles.Contains(i) && toggles[i].isOn)
            {
                correctCount++; // Correct toggle is selected
            }
            else if (!correctToggles.Contains(i) && toggles[i].isOn)
            {
                ShowTextIncorrect.SetActive(true);
                ShowTextCorrect.SetActive(false);
                failcount++;

                if (failcount > 5)
                {
                    ShowSkipButton();
                    ShowQuizAnswer();
                }
                Debug.Log("Incorrect. You selected extra wrong answers.");
                return;
            }
        }

        // Validate if exactly 6 correct answers are selected
        if (correctCount == correctToggles.Count)
        {
            
            ShowTextCorrect.SetActive(true);
            ShowTextIncorrect.SetActive(false);
            Debug.Log("Success! You've selected the correct answers.");
            ShowSkipButton();
        }
        else
        {
            failcount++;
            if(failcount > 5)
            {
                ShowSkipButton();
                ShowQuizAnswer();
            }
            ShowTextIncorrect.SetActive(true);
            ShowTextCorrect.SetActive(false);
            Debug.Log("Incorrect. Some correct answers are missing.");
        }
    }

    private void ShowSkipButton()
    {
        ButtonShow.SetActive(true);
    }

    private void ShowQuizAnswer()
    {
        QuizAnswer.SetActive(true);
    }

}
