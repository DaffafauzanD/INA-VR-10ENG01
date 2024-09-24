using UnityEngine;
using UnityEngine.UI;
public class QuestList : MonoBehaviour
{
    public Toggle[] toggles;
    void OnEnable()
    {
        foreach (var item in toggles)
        {
            item.isOn = false;
        }
    }
    public void SetUpdate()
    {
        for(int i = 0; i < toggles.Length; i++)
        {
            if(toggles[0].isOn == true)
            {
                Debug.Log("true answer");
            }else
            {
                Debug.Log("false answer");
            }
        }
        Menu.instance.Quizlv2.SetActive(false);
        Menu.instance.NextLevel.SetActive(true);
    }
}
