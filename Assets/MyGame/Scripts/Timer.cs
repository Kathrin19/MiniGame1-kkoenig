using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int timeLeft = 60;
    public TextMeshProUGUI countdown;
    private string endScene = "End";
    private string loseTime = "LoseTime";

    void Start()
    {
        StartCoroutine(loseTime);
        Time.timeScale = 1;
    }
    void Update()
    {
        countdown.text = ("00:" + timeLeft.ToString("00"));
        if (timeLeft == 0)
        {
            SceneManager.LoadScene(endScene);
        }
    }

    IEnumerator LoseTime()
    {
        while (timeLeft > 0)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}
