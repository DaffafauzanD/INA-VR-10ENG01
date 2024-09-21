using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLearning : MonoBehaviour
{
    public GameObject uiPanel; // Referensi ke UI Panel yang akan ditampilkan
    public GameObject buttonToDisable;
    public GameObject character;
    //public AudioSource audioSource; // Referensi ke Audio Source

    // Fungsi ini akan dipanggil saat button di-klik
    public void ShowPanelAndPlayAudio()
    {
        // Aktifkan panel UI
        uiPanel.SetActive(true);

        //// Memainkan audio
        //if (audioSource != null)
        //{
        //    audioSource.Play();
        //}
    }

    public void UnShowButtonAnd3D()
    {
        buttonToDisable.SetActive(false);
        character.SetActive(false);
    }
}
