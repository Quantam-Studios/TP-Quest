using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GetTime : MonoBehaviour
{
    public static float time;
    Text timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        TimeSpan timeSpan = TimeSpan.FromSeconds(time);
        string timeText = string.Format("Time: {0:D2}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds);
        timer.text = timeText;
    }
}
