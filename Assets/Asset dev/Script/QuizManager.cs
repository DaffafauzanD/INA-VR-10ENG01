using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    // Array untuk menyimpan pernyataan (7 pernyataan)
    public string[] statements = {
 };

    // Array untuk menyimpan kunci jawaban yang benar (True, False, Not Given)
    public string[] correctAnswers = {  };

    // Toggle untuk setiap pilihan TRUE, FALSE, NOT GIVEN
    public Toggle[] trueToggles;
    public Toggle[] falseToggles;

    // Button untuk mengumpulkan jawaban
    public Button submitButton;

    // Text untuk menampilkan hasil (feedback)
    public Text resultText;

    void Start()
    {
        // Ketika button submit di klik, panggil fungsi untuk mengevaluasi jawaban
        submitButton.onClick.AddListener(CheckAnswers);
    }

    void CheckAnswers()
    {
        int score = 0;

        // Loop untuk memeriksa jawaban tiap pernyataan
        for (int i = 0; i < statements.Length; i++)
        {
            string selectedAnswer = GetSelectedAnswer(i);

            if (selectedAnswer == correctAnswers[i])
            {
                score++;
            }
        }

        // Tampilkan hasil/score kepada pengguna
        resultText.text = "Kamu mendapatkan skor: " + score + " dari " + statements.Length;
    }

    // Fungsi untuk mendapatkan jawaban yang dipilih
    string GetSelectedAnswer(int index)
    {
        if (trueToggles[index].isOn)
        {
            return "TRUE";
        }
        else if (falseToggles[index].isOn)
        {
            return "FALSE";
        }

        return "NONE"; // Jika tidak ada yang dipilih
    }
}