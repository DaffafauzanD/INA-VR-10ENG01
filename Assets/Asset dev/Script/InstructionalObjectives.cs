using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructionalObjectives: MonoBehaviour
{
    public GameObject uiPanel; // Referensi ke UI Panel yang akan ditampilkan
    public AudioSource audioSource; // Referensi ke Audio Source

    // Fungsi ini akan dipanggil saat button di-klik
    public void ShowPanelAndPlayAudio()
    {
        // Aktifkan panel UI
        uiPanel.SetActive(true);

        // Memainkan audio
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}
