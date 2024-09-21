using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScriptAnimation : MonoBehaviour
{
    Animator  animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log(animator);
    }

    // Update is called once per frame
    void Update()
    {
        if (animator != null) { 
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (animator != null)
        {
            Debug.Log(eventData + "game object clickked");
        }
    }
}
