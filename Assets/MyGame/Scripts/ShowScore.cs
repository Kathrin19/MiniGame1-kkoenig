using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    public Text scorePoints;
    public MyScore scoreCount;

	void Start ()
    {
        scorePoints.text = scoreCount.score.ToString();	
	}
}
