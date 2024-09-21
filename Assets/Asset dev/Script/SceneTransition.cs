using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneTransition : MonoBehaviour
{
    public Image transitionImage; // Image component dari UI Panel
    public float transitionTime = 1f; // Waktu transisi

    void Start()
    {
        // Pastikan panel awalnya tidak terlihat
        transitionImage.color = new Color(0f, 0f, 0f, 0f);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FindObjectOfType<SceneTransition>().LoadSceneWithTransition("SCENE1-01InstructionalObjectives2");
        }
    }

    public void LoadSceneWithTransition(string sceneName)
    {
        StartCoroutine(TransitionAndLoadScene(sceneName));
    }

    IEnumerator TransitionAndLoadScene(string sceneName)
    {
        // Fade in (dari transparan ke hitam)
        yield return StartCoroutine(FadeIn());

        // Load Scene baru
        SceneManager.LoadScene(sceneName);

        // Fade out (dari hitam ke transparan)
        yield return StartCoroutine(FadeOut());
    }

    IEnumerator FadeIn()
    {
        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / transitionTime;
            transitionImage.color = new Color(0f, 0f, 0f, t);
            yield return null;
        }
    }

    IEnumerator FadeOut()
    {
        float t = 1f;
        while (t > 0f)
        {
            t -= Time.deltaTime / transitionTime;
            transitionImage.color = new Color(0f, 0f, 0f, t);
            yield return null;
        }
    }
}