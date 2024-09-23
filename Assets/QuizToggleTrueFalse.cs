using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizToggleTrueFalse : MonoBehaviour
{
    // Referensi Toggle untuk pernyataan True/False
    public Toggle[] trueToggles;
    public Toggle[] falseToggles;

    // Jawaban benar (True untuk yang benar, False untuk yang salah)
    private bool[] correctAnswers = { true, false, true, false, true };

    // Tombol untuk mengecek jawaban
    public Button checkAnswerButton;

    public GameObject ShowWrong;
    public GameObject ShowCorrect;
    public GameObject[] HideObject;
    public GameObject ShowObject;

    // Fungsi Start untuk menghubungkan tombol cek jawaban
    void Start()
    {
        checkAnswerButton.onClick.AddListener(CheckAnswers);
    }

    // Fungsi untuk mengecek jawaban
    void CheckAnswers()
    {
        bool allCorrect = true;
        for (int i = 0; i < correctAnswers.Length; i++)
        {
            bool isTrueSelected = trueToggles[i].isOn;
            bool isFalseSelected = falseToggles[i].isOn;

            if (correctAnswers[i] == true )
            {
                if (!trueToggles[i].isOn || falseToggles[i].isOn)
                {
                    allCorrect = false;  // The user got this statement wrong
                    break;  // No need to check further, one wrong answer is enough to fail
                }
                

            }
            else if (correctAnswers[i] == false )
            {
                if (!falseToggles[i].isOn || trueToggles[i].isOn)
                {
                    allCorrect = false;  // The user got this statement wrong
                    break;  // No need to check further
                }
            }
        }

        if (allCorrect)
        {
            Debug.Log("All answers are correct!");
            ShowCorrect.SetActive(true);
            ShowWrong.SetActive(false);
            ShowObject.SetActive(true);
            for (int i = 0; i < HideObject.Length; i++)
            {
                Debug.Log("Hiding object: " + HideObject[i].name);
                HideObject[i].SetActive(false);
            }
        }
        else
        {
            Debug.Log("Some answers are incorrect!");
            ShowWrong.SetActive(true);
            ShowCorrect.SetActive(false);
        }
    }
}
