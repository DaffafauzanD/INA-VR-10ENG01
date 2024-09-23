using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CubeMapController : MonoBehaviour
{
    public GameObject sphere;

    public Texture kelas, koridor, auditorium, tedx;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("MATERIAL TEXTURE NAME : " + sphere.GetComponent<Renderer>().material.ToString());
        //Debug.Log("MATERIAL TEXTURE NAME : " + sphere.GetComponent<Renderer>().material.GetTexture);
        foreach (string nameTex in sphere.GetComponent<Renderer>().material.GetTexturePropertyNames())
        {
            Debug.Log("MATERIAL TEXTURE NAME : " + nameTex);
            Debug.Log("MATERIAL TEXTURE NAME STRING : " + sphere.GetComponent<Renderer>().material.GetTexture(nameTex));
        }

        //StartCoroutine(ChangeHDRI(5.0f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ChangeHDRI(float delay)
    {
        Debug.Log("YIELDD");
        yield return new WaitForSeconds(delay);
        Debug.Log("YIELDD TEXTURE");
        sphere.GetComponent<Renderer>().material.SetTexture("_Tex", koridor);
    }
}
