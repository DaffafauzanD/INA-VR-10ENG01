using UnityEngine;
using UnityEngine.UI;

public class StopAudioOnClick : MonoBehaviour
{
    public AudioSource audioSource; // Referensi ke Audio Source yang akan dihentikan

    // Fungsi ini akan dipanggil saat button di-klik
    public void StopAudio()
    {
        // Mengecek apakah audio sedang diputar, kemudian menghentikannya
        if (audioSource != null && audioSource.isPlaying)
        {
            audioSource.Stop(); // Hentikan audio yang sedang diputar
        }
    }
}
