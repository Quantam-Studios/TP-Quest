using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class HighScore : MonoBehaviour
{
    public float time;
    Text timer;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        timer = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        time = Timer.HighScore;

        timer.text = "HighScore: " + FinalScore.TrueHighScore;
 
    }
}
