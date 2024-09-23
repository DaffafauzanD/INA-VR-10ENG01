using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RecordAudio : MonoBehaviour
{

    [HideInInspector] public AudioClip recorcedClip;
    [SerializeField] AudioSource audioSource;

    public TextMeshProUGUI startText;

    // Start is called before the first frame update
    void Start()
    {
        audioSource.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartRecording()
    {
        string device = Microphone.devices[0];
        int sampleRate = 44100;
        int lengthSec = 3599;

        if (Microphone.IsRecording(device)) return;

        recorcedClip = Microphone.Start(device, false, lengthSec, sampleRate);
        startText.text = "Recording ...";
    }

    public void PlayRecording()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        } else
        {
            audioSource.clip = recorcedClip;
            audioSource.Play();
        }
        
    }

    public void StopRecording()
    {
        Microphone.End(null);
        startText.text = "Start";
    }
}
