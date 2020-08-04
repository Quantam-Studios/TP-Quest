using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject[] Items;
    public float itemCount;
    public Transform[] spawnSpots;
    public float GoalTime;
    private float SetTime;
    public static bool PowerUpTaken;

    void Start()
    {
        PowerUpTaken = true;
        SetTime = GoalTime;
    }

    void Update()
    {
        if (PowerUpTaken == true)
        {
            GoalTime -= Time.deltaTime;
            if (GoalTime <= 0.0f)
            {
                timeEnded();
                GoalTime = SetTime;
            }
        }
    }

    void timeEnded()
    {
        int randPos21 = Random.Range(0, spawnSpots.Length - 1);
        int randItem = Random.Range(0, Items.Length);
        Instantiate(Items[randItem], spawnSpots[randPos21].position, Quaternion.identity);
        PowerUpTaken = false;
    }
} 