using UnityEngine;
using UnityEngine.UI;
public class ReArrangeTheWord : MonoBehaviour
{
    public GameObject questGroup;
    public string listString;
    public string answerlist;
    private Button button;
    public bool toggle = false;
    public TMPro.TMP_Text isToggle;
    void Start()
    {
        button = GetComponent<Button>();
        isToggle = GetComponentInChildren<TMPro.TMP_Text>(true);
        button.onClick.AddListener(toogleTrue);
    }

    void OnEnable()
    {
        toggle = false;
        listString = "";
        button.interactable = true;
    }
    public void toogleTrue()
    {
        if( toggle == false){
            toggle = true;
            GetAnswer();
        }
        else
        {
            toggle = false;
            listString = "";
        }
        isToggle.gameObject.SetActive(toggle);
        button.interactable = false;
        Menu.instance.UpdateValueArrangeTheworld();
    }
    void GetAnswer()
    {
        AnswerValue[] answerLists = questGroup.GetComponentsInChildren<AnswerValue>();
        foreach (AnswerValue ans in answerLists)
        {
            Debug.Log(ans.arrange);
            listString+=(ans.arrange).ToString();
            if(listString == answerlist)
            {
                isToggle.text = "V";
            }else
            {
                isToggle.text = "X";
            }
        }
    }
    public void SetLevel()
    {

    }
}