using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReflectionController : MonoBehaviour
{

    public GameObject finishButton;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        finishButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleReflection(string nameT)
    {
        
        string[] splitT = nameT.Split("x");
        bool currState = GameObject.Find(splitT[0] + splitT[1]).GetComponent<Toggle>().isOn;
        
        GameObject.Find(splitT[0] + (splitT[1] == "n" ? "y" : "n")).GetComponent<Toggle>().isOn = !currState;

        finishButton.SetActive(AllChecked());

    }

    private bool AllChecked()
    {

        return (GameObject.Find("1y").GetComponent<Toggle>().isOn || GameObject.Find("1n").GetComponent<Toggle>().isOn) &&
                (GameObject.Find("2y").GetComponent<Toggle>().isOn || GameObject.Find("2n").GetComponent<Toggle>().isOn) &&
                (GameObject.Find("3y").GetComponent<Toggle>().isOn || GameObject.Find("3n").GetComponent<Toggle>().isOn) &&
                (GameObject.Find("4y").GetComponent<Toggle>().isOn || GameObject.Find("4n").GetComponent<Toggle>().isOn) &&
                (GameObject.Find("5y").GetComponent<Toggle>().isOn || GameObject.Find("5n").GetComponent<Toggle>().isOn) &&
                (GameObject.Find("6y").GetComponent<Toggle>().isOn || GameObject.Find("6n").GetComponent<Toggle>().isOn) &&
                (GameObject.Find("7y").GetComponent<Toggle>().isOn || GameObject.Find("7n").GetComponent<Toggle>().isOn) &&
                (GameObject.Find("8y").GetComponent<Toggle>().isOn || GameObject.Find("8n").GetComponent<Toggle>().isOn) &&
                (GameObject.Find("9y").GetComponent<Toggle>().isOn || GameObject.Find("9n").GetComponent<Toggle>().isOn);
    }

    public void finishReflection()
    {
        audioSource.Play();
    } 
}
