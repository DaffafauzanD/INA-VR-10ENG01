using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuizScriptReadingLevel2 : MonoBehaviour
{
    // Dropdown references
    public TMP_Dropdown[] dropdowns;

    public Vector3 initialPositionCorrect;
    public Vector3 initialPositionWrong;

    public Vector3 secondPositionCorrect;
    public Vector3 secondPositionWrong;

    // Correct answers (index based on dropdown options)
    private int[] correctAnswers = { 0, 1, 2, 3, 4 };

    // Text to show result
    public GameObject resultObject;
    public GameObject WrongObject;
    public GameObject FinishButton;

    public void CheckAnswers()
    {
        int correctCount = 0;
        bool allCorrect = true;

        // Loop through each dropdown and check the answer
        for (int i = 0; i < dropdowns.Length; i++)
        {
            Debug.Log(dropdowns[i].value);
            if (dropdowns[i].value == correctAnswers[i])
            {
                correctCount++;
            }
            else
            {
                allCorrect = false;
            }
        }

        if (allCorrect)
        {
            resultObject.transform.position = initialPositionCorrect;
            resultObject.SetActive(true);
            FinishButton.SetActive(true);
            WrongObject.SetActive(false);
        }
        else
        {
            WrongObject.transform.position = initialPositionWrong;
            WrongObject.SetActive(true);
            FinishButton.SetActive(false);
            resultObject.SetActive(false);
        }

        // Display the result
        Debug.Log("You got " + correctCount + " out of " + dropdowns.Length + " correct!");
    }

    public void ResetPosition()
    {
        resultObject.transform.position = secondPositionCorrect;
        WrongObject.transform.position = secondPositionWrong;
    }
}