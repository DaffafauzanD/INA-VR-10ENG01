using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageGamesLevel1 : MonoBehaviour
{
    public GameObject uiPanel; // Referensi ke UI Panel yang akan ditampilkan
    public GameObject panelStart; // Referensi ke UI Panel yang akan ditampilkan
    public GameObject panelMatchQuiz; // Referensi ke UI Panel yang akan ditampilkan
    public GameObject panelChoose; // Referensi ke UI Panel yang akan ditampilkan
    public GameObject Character; // Referensi ke UI Panel yang akan ditampilkan
    public GameObject PanelFindMe; // Referensi ke UI Panel yang akan ditampilkan
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
    public void UnShowPanelFindMe()
    {
        // Aktifkan panel UI
        PanelFindMe.SetActive(false);

        //// Memainkan audio
        //if (audioSource != null)
        //{
        //    audioSource.Play();
        //}
    }
    public void NextLevel2()
    {
        Character.SetActive(false);
        panelStart.SetActive(false);
        panelChoose.SetActive(false);
        panelMatchQuiz.SetActive(false);
    }
}
