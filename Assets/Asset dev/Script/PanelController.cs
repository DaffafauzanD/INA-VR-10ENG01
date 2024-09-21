using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PanelController : MonoBehaviour
{
    public GameObject panel; // Referensi ke panel yang akan di-show
    public float delay = 5f; // Waktu delay dalam detik

    void Start()
    {
        // Sembunyikan panel di awal
        panel.SetActive(false);

        // Mulai Coroutine untuk menampilkan panel setelah delay
        StartCoroutine(ShowPanel());
    }

    IEnumerator ShowPanel()
    {
        // Tunggu sesuai waktu delay yang ditentukan
        yield return new WaitForSeconds(delay);

        // Tampilkan panel setelah delay
        panel.SetActive(true);
    }
}
