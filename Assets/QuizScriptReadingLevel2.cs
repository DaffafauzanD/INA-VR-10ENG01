using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuizScriptReadingLevel2 : MonoBehaviour
{
    // Dropdown references
    public TMP_Dropdown[] dropdowns;

    // Correct answers (index based on dropdown options)
    private int[] correctAnswers = { 1, 0, 4, 2, 3 };

    // Text to show result
    public GameObject resultObject;
    public GameObject WrongObject;
    public GameObject FinishButton;

    public void CheckAnswers()
    {
        int correctCount = 0;

        // Loop through each dropdown and check the answer
        for (int i = 0; i < dropdowns.Length; i++)
        {
            if (dropdowns[i].value == correctAnswers[i])
            {
                correctCount++;
                resultObject.SetActive(true);
                FinishButton.SetActive(true);
                WrongObject.SetActive(false);
            }
            else
            {
                correctCount++;
                WrongObject.SetActive(true);
                FinishButton.SetActive(false);
                resultObject.SetActive(false);
            }
        }

        // Display the result
        Debug.Log("You got " + correctCount + " out of " + dropdowns.Length + " correct!");
    }
}
