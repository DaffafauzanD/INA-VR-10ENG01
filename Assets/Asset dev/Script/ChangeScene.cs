using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void MoveToScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        setEyeTargetNone();
    }

    public void LoadPreviousScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        setEyeTargetNone();
    }

    public void setEyeTargetNone()
    {
        Debug.Log("SCENE NAME : " + SceneManager.GetActiveScene().name);
        Camera.main.stereoTargetEye = StereoTargetEyeMask.None;
    }
}
