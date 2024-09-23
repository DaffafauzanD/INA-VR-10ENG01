using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScriptShowHide : MonoBehaviour
{
    // Referensi untuk teks yang ingin di-show/unhide
    public GameObject textObject; // Teks yang ingin ditampilkan atau disembunyikan

    // Referensi untuk tombol yang mengontrol show/unhide
    public Button showTextButton;

    // Variabel untuk melacak status tampilan (hidden/shown)
    private bool isTextShown = false;

    void Start()
    {
        // Pastikan teks dimulai dalam keadaan tersembunyi
        textObject.SetActive(false);

        // Assign action saat tombol diklik
        showTextButton.onClick.AddListener(ToggleText);
    }

    // Method untuk menampilkan atau menyembunyikan teks
    void ToggleText()
    {
        // Jika teks sedang disembunyikan, tampilkan; jika ditampilkan, sembunyikan
        isTextShown = !isTextShown;
        textObject.SetActive(isTextShown);
    }
}
