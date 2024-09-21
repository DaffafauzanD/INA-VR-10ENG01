using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonController : MonoBehaviour
{
    public Button targetButton; // Referensi ke Button yang ingin ditampilkan
    public float delay = 5f; // Waktu delay sebelum button muncul

    void Start()
    {
        // Pastikan button disembunyikan di awal
        targetButton.gameObject.SetActive(false);
        // Mulai coroutine untuk menampilkan button setelah waktu tertentu
        StartCoroutine(ShowButtonAfterDelay());
    }

    IEnumerator ShowButtonAfterDelay()
    {
        // Tunggu sesuai waktu delay yang ditentukan
        yield return new WaitForSeconds(delay);
        // Tampilkan button
        targetButton.gameObject.SetActive(true);
    }
}
