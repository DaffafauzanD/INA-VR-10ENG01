using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class MatchTheWordQuiz : MonoBehaviour
{
    // Dropdowns or other UI elements for selecting meanings for each word
    public List<TMP_Dropdown> wordDropdowns;

    // gameobjects to show if the answer is correct or wrong
    public GameObject ShowWrong;
    public GameObject ShowCorrect;

    // Button to display the next question
    public GameObject DisplayButtonNext;

    // Positions for ShowWrong and ShowCorrect
    public Vector3 correctPosition;
    public Vector3 wrongPosition;

    public Vector3 initialCorrectPosition;
    public Vector3 initialWrongPosition;

    // Correct mapping of word indices to meaning indices
    private Dictionary<int, int> correctMatches = new Dictionary<int, int>
    {
        { 0, 0 }, // Sporty -> someone is really interested in sport and plays sport often
        { 1, 1 }, // Fanatic -> someone who only cares about one thing
        { 2, 2 }, // Athletic -> someone who is in good shape and enjoys exercise and sport
        { 3, 3 }, // Recently -> not long ago, or at a time that started not long ago
        { 4, 4 }  // Occasionally -> sometimes but not often
    };

   
  

    // Function to check if the word matches are correct
    public void CheckMatches()
    {
        bool allCorrect = true;

        // Loop through all dropdowns (words) and check their selected meanings
        for (int i = 0; i < wordDropdowns.Count; i++)
        {
            // Check if the selected meaning matches the correct one
            if (wordDropdowns[i].value != correctMatches[i])
            {
                allCorrect = false;
                break;
            }
        }

        // Display the result and update positions
        if (allCorrect)
        {
            Debug.Log("Success! You've matched all words correctly.");
            ShowCorrect.transform.position = correctPosition;
            ShowCorrect.SetActive(true);
            DisplayButtonNext.SetActive(true);
            ShowWrong.SetActive(false);
        }
        else
        {
            Debug.Log("Incorrect. Please try again!");
            ShowWrong.transform.position = wrongPosition;
            ShowWrong.SetActive(true);
            ShowCorrect.SetActive(false);
        }
    }
    public void ResetPositions()
    {
        ShowCorrect.transform.position = initialCorrectPosition;
        ShowWrong.transform.position = initialWrongPosition;
    }
}

