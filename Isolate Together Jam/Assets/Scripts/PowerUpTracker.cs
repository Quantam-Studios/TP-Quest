using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PowerUpTracker : MonoBehaviour
{
    // Time
    public static float time2;
    public Text timer;
    public static float Score;
    // Image
    public GameObject PowerUP;
    public Sprite[] Possible;
    public static int CurrentPower;
    public int Testing;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PowerUP.GetComponent<Image>().sprite = Possible[CurrentPower];
        time2 -= Time.deltaTime;
        TimeSpan timeSpan = TimeSpan.FromSeconds(time2);
        string timeText = string.Format("     : {0:D2}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds);
        timer.text = timeText;
        Score = time2;
        if (time2 <= 0)
        {
            time2 = Testing;
            this.gameObject.SetActive(false);
        }
    }
}
