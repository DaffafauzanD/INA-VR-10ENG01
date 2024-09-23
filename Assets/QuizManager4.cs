using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;


public class QuizManager4 : MonoBehaviour
{
    // Referensi untuk dropdowns
    public TMP_Dropdown dropdownSpeed;
    public TMP_Dropdown dropdownSuccess;
    public TMP_Dropdown dropdownJump;
    public TMP_Dropdown dropdownGoalSkill;
    public TMP_Dropdown dropdownTraining;

    // Tombol untuk memeriksa jawaban
    public Button checkButton;

    // Text untuk menampilkan hasil
    public GameObject resultText;
    public GameObject NextButton;

    // Jawaban yang benar (nomor paragraf yang benar)
    private int correctSpeed = 3;    // Paragraf 3
    private int correctSuccess = 5;  // Paragraf 5
    private int correctJump = 4;     // Paragraf 4
    private int correctGoalSkill = 2;// Paragraf 2
    private int correctTraining = 1; // Paragraf 1

    void Start()
    {
        // Assign action saat tombol diklik
        checkButton.onClick.AddListener(CheckAnswers);
    }

    void CheckAnswers()
    {
        // Mendapatkan nilai yang dipilih dari dropdown (indeks + 1 untuk mencocokkan nomor paragraf)
        int selectedSpeed = dropdownSpeed.value + 1;
        int selectedSuccess = dropdownSuccess.value + 1;
        int selectedJump = dropdownJump.value + 1;
        int selectedGoalSkill = dropdownGoalSkill.value + 1;
        int selectedTraining = dropdownTraining.value + 1;

        // Memeriksa apakah semua jawaban benar
        if (selectedSpeed == correctSpeed && selectedSuccess == correctSuccess && selectedJump == correctJump &&
            selectedGoalSkill == correctGoalSkill && selectedTraining == correctTraining)
        {
            Debug.Log("Correct! All answers are right.");
            resultText.SetActive(true);
            NextButton.SetActive(true);
        }
        else
        {
            Debug.Log("Incorrect. Please try again!");
        }
    }
}
