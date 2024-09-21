using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSceneChanger : MonoBehaviour
{
    // Fungsi ini dipanggil ketika tombol diklik
    public void LoadNextScene(string sceneName)
    {
        Debug.Log("Button clicked, attempting to load scene: " + sceneName);
    SceneManager.LoadScene(sceneName);
}
    }

