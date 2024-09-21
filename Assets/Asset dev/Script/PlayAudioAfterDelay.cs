using System.Collections;
using UnityEngine;

public class PlayAudioAfterDelay : MonoBehaviour
{
    public AudioSource audioSource;  // Reference ke Audio Source
    public float delay = 10f;        // Waktu delay sebelum audio diputar

    void Start()
    {
        // Memulai Coroutine untuk memutar audio setelah delay
        StartCoroutine(PlayAudioWithDelay());
    }

    IEnumerator PlayAudioWithDelay()
    {
        // Tunggu selama 10 detik
        yield return new WaitForSeconds(delay);

        // Putar audio
        audioSource.Play();
    }
}
