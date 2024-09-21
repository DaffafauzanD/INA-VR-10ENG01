using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericStructure : MonoBehaviour
{
    public GameObject uiPanel; // Referensi ke UI Panel yang akan ditampilkan
    public GameObject SocialFunctionPanel; // Referensi ke UI Panel yang akan ditampilkan
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
    public void UnShowPanelSocialFunction()
    {
        // Aktifkan panel UI
        SocialFunctionPanel.SetActive(false);

        //// Memainkan audio
        //if (audioSource != null)
        //{
        //    audioSource.Play();
        //}
    }
}
