using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class Timer : MonoBehaviour
{
    public static float time;
    Text timer;
    public static float Score;
    public static float HighScore;
    public static bool startTime;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        timer = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
            time += Time.deltaTime;
            TimeSpan timeSpan = TimeSpan.FromSeconds(time);
            string timeText = string.Format("Time: {0:D2}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds);
            timer.text = timeText;
        Score = time;
    }


}
