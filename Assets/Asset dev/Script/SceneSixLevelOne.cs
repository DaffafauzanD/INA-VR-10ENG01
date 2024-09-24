using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneSixLevelOne : MonoBehaviour
{
    public CubeMapController cubeMapController;

    public GameObject athletes,
                        mtyson, mjordan, cronaldo, lebron, lalu, instructor,
                        audioInstructor, audioConversation,
                        btnSpeaking, btnStart,
                        conversationUI, nextUI, topicUI, speechUI, recordingUI;
    public TextMeshProUGUI titleText, timerText, nextText;
    public AudioClip[] ACInstructor, ACConversation;

    private Vector3 originMTyson, originMJordan, originCRonaldo, originLebron, originLalu;

    private bool isSpeakingConv = false, isSpeech = false, isOpeningLevel2 = false;

    private float timeLeft = 90f;

    // Start is called before the first frame update
    void Start()
    {
        //athletes.SetActive(false);
        //mtyson.transform.position = instructor.transform.position;
        cubeMapController = FindObjectOfType<CubeMapController>();
        btnSpeaking.SetActive(false);
        btnStart.SetActive(false);
        conversationUI.SetActive(false);
        nextUI.SetActive(false);
        athletes.SetActive(false);
        topicUI.SetActive(false);
        speechUI.SetActive(false);
        recordingUI.SetActive(false);
        originMTyson = mtyson.transform.position;
        originMJordan = mjordan.transform.position;
        originCRonaldo = cronaldo.transform.position;
        originLebron = lebron.transform.position;
        originLalu= lalu.transform.position;
        //Debug.Log("Ins SIZE Y : " + instructor.GetComponent<Renderer>().bounds.size.y);


    }

    // Update is called once per frame
    void Update()
    {
        
        if (!audioInstructor.GetComponent<AudioSource>().isPlaying)
        {
            if (cubeMapController.sphere.GetComponent<Renderer>().material.GetTexture("_Tex") == cubeMapController.kelas)
            {
                Debug.Log("MATERIAL TEXTURE IS KELAS : " + (cubeMapController.sphere.GetComponent<Renderer>().material.GetTexture("_Tex") == cubeMapController.kelas ? "Kelas" : "none"));
                cubeMapController.sphere.GetComponent<Renderer>().material.SetTexture("_Tex", cubeMapController.koridor);
                btnSpeaking.SetActive(true);
            }
        }

        if (isSpeakingConv && cubeMapController.sphere.GetComponent<Renderer>().material.GetTexture("_Tex") == cubeMapController.auditorium && !audioConversation.GetComponent<AudioSource>().isPlaying && !conversationUI.active)
        {
            conversationUI.SetActive(true);
            audioConversation.SetActive(false);
            isSpeakingConv = false;
        }

        if (cubeMapController.sphere.GetComponent<Renderer>().material.GetTexture("_Tex") == cubeMapController.tedx)
        {
            if (isSpeech && !topicUI.active && speechUI.active)
            {
                timeLeft -= Time.deltaTime;
                timerText.text = (timeLeft).ToString("0");
                if (timeLeft <= 0)
                {
                    topicUI.SetActive(true);
                    speechUI.SetActive(false);
                    isSpeech = false;
                    timeLeft = 90f;
                }
            }

            if (audioInstructor.GetComponent<AudioSource>().clip == ACInstructor[1] && !audioInstructor.GetComponent<AudioSource>().isPlaying && isOpeningLevel2)
            {
                isOpeningLevel2 = false;
                nextUI.SetActive(true);
            }
        }

        


    }

    void ChangeAudioInstructor(int idxInstructor)
    {
        audioConversation.GetComponent<AudioSource>().Stop();
        audioInstructor.GetComponent<AudioSource>().clip = ACInstructor[idxInstructor];
        audioInstructor.GetComponent<AudioSource>().Play();
    }

    public void SpeakingOnClick()
    {
        cubeMapController.sphere.GetComponent<Renderer>().material.SetTexture("_Tex", cubeMapController.auditorium);
        btnSpeaking.SetActive(false);
        athletes.SetActive(true);
        nextUI.SetActive(true);
        btnStart.SetActive(true);
    }

    public void StartClicked()
    {
        btnStart.SetActive(false);
        conversationUI.SetActive(true);
        ChangeAudioInstructor(1);
    }

    public void AthletesClicked(GameObject athlete)
    {
        //Debug.Log("ATHLETES CLICKED : " + NameAthletes);
        Debug.Log("ATHLETES CLICKED : " + athlete.name);
        hideAthleteExcept(athlete);
    }

    private void hideAthleteExcept(GameObject athlete)
    {
        mtyson.SetActive(false);
        mtyson.transform.position = originMTyson;
        mjordan.SetActive(false);
        mjordan.transform.position = originMJordan;
        cronaldo.SetActive(false);
        cronaldo.transform.position = originCRonaldo;
        lebron.SetActive(false);
        lebron.transform.position = originLebron;
        lalu.SetActive(false);
        lalu.transform.position = originLalu;


        athlete.SetActive(true);
        athlete.transform.position = athletes.transform.position;

        conversationUI.SetActive(true);
        conversationUI.transform.position = athletes.transform.position + Vector3.forward * -3 + Vector3.up * 2;
        conversationUI.transform.LookAt(Camera.main.transform);
        conversationUI.transform.eulerAngles = new Vector3(0, conversationUI.transform.eulerAngles.y - 180f, 0);

        recordingUI.SetActive(true);
        recordingUI.transform.position = conversationUI.transform.position + Vector3.forward * -3;
        recordingUI.transform.LookAt(Camera.main.transform);
        recordingUI.transform.eulerAngles = new Vector3(0, recordingUI.transform.eulerAngles.y - 180f, 0);
    }

    public void chooseConversation(int idxConv)
    {
        isSpeakingConv = true;
        conversationUI.SetActive(false);
        audioConversation.SetActive(true);
        audioInstructor.SetActive(false);
        recordingUI.SetActive(true);
        audioInstructor.GetComponent<AudioSource>().Stop();
        audioConversation.GetComponent<AudioSource>().Stop();
        audioConversation.GetComponent<AudioSource>().clip = ACConversation[idxConv];
        audioConversation.GetComponent<AudioSource>().Play();
    }

    public void closeConversationUI()
    {
        conversationUI.transform.position = athletes.transform.position;
        conversationUI.SetActive(false);

        mtyson.SetActive(true);
        mtyson.transform.position = originMTyson;
        mjordan.SetActive(true);
        mjordan.transform.position = originMJordan;
        cronaldo.SetActive(true);
        cronaldo.transform.position = originCRonaldo;
        lebron.SetActive(true);
        lebron.transform.position = originLebron;
        lalu.SetActive(true);
        lalu.transform.position = originLalu;

        audioConversation.SetActive(false);
        audioInstructor.SetActive(true);
        audioInstructor.GetComponent<AudioSource>().Stop();
        audioConversation.GetComponent<AudioSource>().Stop();
        isSpeakingConv = false;
        Microphone.End(null);
        FindObjectOfType<RecordAudio>().recorcedClip = null;
        recordingUI.SetActive(false);
    }

    public void NextLevel()
    {
        if (nextText.text == "Next")
        {
            athletes.SetActive(false);
            cubeMapController.sphere.GetComponent<Renderer>().material.SetTexture("_Tex", cubeMapController.tedx);
            audioInstructor.GetComponent<AudioSource>().clip = ACInstructor[1];
            audioInstructor.GetComponent<AudioSource>().Play();
            topicUI.SetActive(true);
            nextText.text = "Finish";
            nextUI.SetActive(false);
            isOpeningLevel2 = true;
        } else if (nextText.text == "Finish")
        {
            SceneManager.LoadScene(0);
        }


    }

    public void chooseTopic(string title)
    {
        topicUI.SetActive(false);
        speechUI.SetActive(true);
        titleText.text = title;
        timerText.text = "90";
        isSpeech = true;
    }

    public void exitRecording()
    {
        Microphone.End(null);
    }
}
