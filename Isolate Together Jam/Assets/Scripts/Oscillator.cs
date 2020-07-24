using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    float timeCounter;
    public Vector3 CurrentPos;
    float width = 50;
    float height = 50;
    public float GoalTime;
    public float SetTime;
    public GameObject Self;

    void Start()
    {

    }
   
    // Update is called once per frame
    void Update()
    {
        GoalTime -= Time.deltaTime;
        CurrentPos = transform.parent.position;
        timeCounter += Time.deltaTime;

        float x = CurrentPos.x + (Mathf.Cos(timeCounter) * width);
        float y = CurrentPos.y + (Mathf.Sin(timeCounter) * height);
        float z = CurrentPos.z;

        if(GoalTime > 0)
        {
            transform.position = new Vector3(x, y, z);
        }

        if (GoalTime <= 0)
        {
            Self.SetActive(false);
            GoalTime = SetTime;
        }
    }
}
