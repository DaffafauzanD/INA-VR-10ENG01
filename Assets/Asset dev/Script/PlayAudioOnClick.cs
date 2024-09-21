using UnityEngine;
using UnityEngine.UI;

public class PlayAudioOnClick : MonoBehaviour
{
    public Button playButton; // Button untuk memulai audio
    public AudioSource audioSource; // AudioSource yang akan dimainkan

    void Start()
    {
        // Pastikan AudioSource sudah diassign
        if (audioSource != null)
        {
            // Menambahkan listener untuk tombol
            playButton.onClick.AddListener(PlayAudio);
        }
        else
        {
            Debug.LogError("AudioSource belum di-assign di inspector.");
        }
    }

    void PlayAudio()
    {
        if (!audioSource.isPlaying) // Jika AudioSource tidak sedang diputar
        {
            audioSource.Play(); // Mulai memutar audio
        }
    }
}
