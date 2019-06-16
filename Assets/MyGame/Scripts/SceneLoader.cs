using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private string introScene = "Intro";
    private string mainScene = "Main";
    private string endScene = "End";

    public void LoadSceneIntro()
    {
        SceneManager.LoadScene(introScene);
    }

    public void LoadSceneMain()
    {
        SceneManager.LoadScene(mainScene);
    }

    public void LoadSceneEnd()
    {
        SceneManager.LoadScene(endScene);
    }
}
