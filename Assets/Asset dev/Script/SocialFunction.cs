using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocialFunction : MonoBehaviour
{
    public GameObject uiPanel; // Referensi ke UI Panel yang akan ditampilkan
    public GameObject DecsriptiveTextPanel; // Referensi ke UI Panel yang akan ditampilkan
    //public AudioSource audioSource; // Referensi ke Audio Source

    // Fungsi ini akan dipanggil saat button di-klik
    public void ShowPanel()
    {
        // Aktifkan panel UI
        uiPanel.SetActive(true);

        //// Memainkan audio
        //if (audioSource != null)
        //{
        //    audioSource.Play();
        //}
    }
    public void UnShowPanelDecsText()
    {
        // Aktifkan panel UI
        DecsriptiveTextPanel.SetActive(false);

        //// Memainkan audio
        //if (audioSource != null)
        //{
        //    audioSource.Play();
        //}
    }
}
