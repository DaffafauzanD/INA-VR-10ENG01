using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using TMPro.Examples;

public class QuizTrueFalse : MonoBehaviour
{
    // Referensi untuk dropdowns
    public TMP_Dropdown dropdownQ1; // Pertanyaan 1
    public TMP_Dropdown dropdownQ2; // Pertanyaan 2
    public TMP_Dropdown dropdownQ3; // Pertanyaan 3
    public TMP_Dropdown dropdownQ4; // Pertanyaan 4
    public TMP_Dropdown dropdownQ5; // Pertanyaan 5

    // Tombol untuk memeriksa jawaban
    public Button checkButton;

    public GameObject ShowCorrectObject;
    public GameObject ShowInCorrectObject;
    public GameObject ShowMenuQuiz;

    // Jawaban yang benar (0 = True, 1 = False, sesuai dropdown)
    private int correctQ1 = 0;  // True (The main idea of the text is Ronaldo's strong determination)
    private int correctQ2 = 1;  // False (Ronaldo can use both legs efficiently)
    private int correctQ3 = 1;  // False (Speed is higher than 20.6 km/h)
    private int correctQ4 = 0;  // True (Ronaldo's G-force is higher than a cheetah)
    private int correctQ5 = 0;  // True (Net worth is $500 million)

    void Start()
    {
        // Assign action saat tombol diklik
        checkButton.onClick.AddListener(CheckAnswers);
    }

    void CheckAnswers()
    {
        // Mendapatkan nilai yang dipilih dari dropdown (0 untuk True, 1 untuk False)
        int selectedQ1 = dropdownQ1.value;
        int selectedQ2 = dropdownQ2.value;
        int selectedQ3 = dropdownQ3.value;
        int selectedQ4 = dropdownQ4.value;
        int selectedQ5 = dropdownQ5.value;

        // Memeriksa apakah semua jawaban benar
        if (selectedQ1 == correctQ1 && selectedQ2 == correctQ2 && selectedQ3 == correctQ3 &&
            selectedQ4 == correctQ4 && selectedQ5 == correctQ5)
        {
            Debug.Log("Correct! All answers are right.");
            ShowCorrectObject.SetActive(true);
            ShowMenuQuiz.SetActive(true);
            ShowInCorrectObject.SetActive(false);
        }
        else
        {
            ShowInCorrectObject.SetActive(true);
            ShowCorrectObject.SetActive(false);
            ShowMenuQuiz.SetActive(false);
            Debug.Log("Incorrect. Please try again!");
        }
    }
}
