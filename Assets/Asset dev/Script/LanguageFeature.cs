using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageFeature : MonoBehaviour
{
    public GameObject uiPanel; // Referensi ke UI Panel yang akan ditampilkan
    public GameObject GenericStructurePanel; // Referensi ke UI Panel yang akan ditampilkan
    public GameObject PanelReadyToStart; // Referensi ke UI Panel yang akan ditampilkan
    public GameObject PanelChoose; // Referensi ke UI Panel yang akan ditampilkan
    //public AudioSource audioSource; // Referensi ke Audio Source

    // Fungsi ini akan dipanggil saat button di-klik
    public void ShowPanel()
    {
        // Aktifkan panel UI
        uiPanel.SetActive(true);
        PanelReadyToStart.SetActive(true);
        PanelChoose.SetActive(true);

        //// Memainkan audio
        //if (audioSource != null)
        //{
        //    audioSource.Play();
        //}
    }
    public void UnShowPanelGenericStructure()
    {
        // Aktifkan panel UI
        GenericStructurePanel.SetActive(false);

        //// Memainkan audio
        //if (audioSource != null)
        //{
        //    audioSource.Play();
        //}
    }
}
