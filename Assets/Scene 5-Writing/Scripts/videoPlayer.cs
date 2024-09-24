using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class videoPlayer : MonoBehaviour
{
    public VideoPlayer player;
    public bool isPlaying = false;
    // Start is called before the first frame update
    public void StartPlay()
    {
        if(isPlaying == false)
        {
            player.Play();
            isPlaying = true;
            player.loopPointReached += CheckOver;
        }
    }
    void CheckOver(VideoPlayer vp)
    {
        print  ("Video Is Over");
        Menu.instance.Quizlv1.SetActive(true);
        isPlaying = false;
    }

    public void playerSkip()
    {
        player.Stop();
        Menu.instance.Quizlv1.SetActive(true);
        isPlaying = false;
    }
}
