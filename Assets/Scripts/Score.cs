using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    private int currentScore;
    private Text scoreText;

    // Use this for initialization
    void Start()
    {
        currentScore = 0;
        scoreText = GetComponent<Text>();
        UpdateScore();
    }

    public void UpdateScore()
    {
        //currentScore ++;
        //UpdateText();
    }

    //void UpdateText()
    //{
    //    scoreText.text = "Score: " + currentScore;
    //}
}
