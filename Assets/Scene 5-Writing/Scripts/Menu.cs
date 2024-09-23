using UnityEngine;
using System.Collections;
public class Menu : MonoBehaviour
{
    public static Menu instance;
    public AudioSource audioSource;
    [Header("UI")]
    public GameObject Quizlv1;
    public GameObject Quizlv2;
    public GameObject NextLevel;
    public GameObject popUpWelcome;
    public GameObject arrangeWords;
    public int arrangeWordsCount = 5;
    public int WordsCount = 0;
    public bool isFinish;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    public void UpdateValueArrangeTheworld()
    {
        ReArrangeTheWord [] reArrangeTheWords = arrangeWords.GetComponentsInChildren<ReArrangeTheWord>();
        arrangeWordsCount = reArrangeTheWords.Length;
        foreach (ReArrangeTheWord reArrange in reArrangeTheWords)
        {
            if(reArrange.toggle == true)
            {
                WordsCount+=1;
            }
        }
        if(arrangeWordsCount == WordsCount)
        {
            Quizlv1.SetActive(false);
            Quizlv2.SetActive(true);
        }
    }
    public void PlayIntroSfx()
    {

        StartCoroutine(waitForSound());
    }
    IEnumerator waitForSound()
    {
        if(isFinish == true)
        {
            Quizlv2.SetActive(false);
            popUpWelcome.SetActive(true);
        }
        audioSource.Play();

        while (audioSource.isPlaying)
        {
            yield return null;
        }
        popUpWelcome.SetActive(false);
        audioSource.Stop();
        if(isFinish == false)
        {
            Quizlv1.SetActive(true);
        }else
        {
            NextLevel.SetActive(true);
        }
    }
    public void GoToScene(string sceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}
