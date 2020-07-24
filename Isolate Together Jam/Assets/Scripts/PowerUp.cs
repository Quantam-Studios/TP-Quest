using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject Item;
    public GameObject Item2;
    public GameObject Item3;
    public float itemCount;
    public Transform[] spawnSpots;
    public float GoalTime;
    public float SetTime;
    public static bool PowerUpTaken;

    void Start()
    {
        PowerUpTaken = true;
    }

    void Update()
    {
        GoalTime -= Time.deltaTime;
        if (GoalTime <= 0.0f)
        {
            timeEnded();
            GoalTime = SetTime;
        }
    }

    void timeEnded()
    {
        int randNum2 = Random.Range(0, 3);
        if (randNum2 == 0)
        {
            if (PowerUpTaken == true)
            {
                if (itemCount == 1 && PowerUpTaken == true)
                {
                    int randPos21 = Random.Range(0, spawnSpots.Length - 1);
                    Instantiate(Item2, spawnSpots[randPos21].position, Quaternion.identity);
                    PowerUpTaken = false;
                }

                if (itemCount == 2 && PowerUpTaken == true)
                {
                    int randPos22 = Random.Range(0, spawnSpots.Length - 1);
                    Instantiate(Item2, spawnSpots[randPos22].position, Quaternion.identity);
                    int randPos23 = Random.Range(0, spawnSpots.Length - 1);
                    Instantiate(Item2, spawnSpots[randPos23].position, Quaternion.identity);
                    PowerUpTaken = false;
                }
                if (itemCount == 3 && PowerUpTaken == true)
                {
                    int randPos24 = Random.Range(0, spawnSpots.Length - 1);
                    Instantiate(Item2, spawnSpots[randPos24].position, Quaternion.identity);
                    int randPos25 = Random.Range(0, spawnSpots.Length - 1);
                    Instantiate(Item2, spawnSpots[randPos25].position, Quaternion.identity);
                    int randPos26 = Random.Range(0, spawnSpots.Length - 1);
                    Instantiate(Item2, spawnSpots[randPos26].position, Quaternion.identity);
                    PowerUpTaken = false;
                }

                if (itemCount == 4 && PowerUpTaken == true)
                {
                    int randPos27 = Random.Range(0, spawnSpots.Length - 1);
                    Instantiate(Item2, spawnSpots[randPos27].position, Quaternion.identity);
                    int randPos28 = Random.Range(0, spawnSpots.Length - 1);
                    Instantiate(Item2, spawnSpots[randPos28].position, Quaternion.identity);
                    int randPos29 = Random.Range(0, spawnSpots.Length - 1);
                    Instantiate(Item2, spawnSpots[randPos29].position, Quaternion.identity);
                    int randPos30 = Random.Range(0, spawnSpots.Length - 1);
                    Instantiate(Item2, spawnSpots[randPos30].position, Quaternion.identity);
                    PowerUpTaken = false;
                }
            }
        }

        if (randNum2 == 1)
        {
            if (PowerUpTaken == true)
            {
                if (itemCount == 1 && PowerUpTaken == true)
                {
                    int randPos41 = Random.Range(0, spawnSpots.Length - 1);
                    Instantiate(Item, spawnSpots[randPos41].position, Quaternion.identity);
                    PowerUpTaken = false;
                }

                if (itemCount == 2 && PowerUpTaken == true)
                {
                    int randPos42 = Random.Range(0, spawnSpots.Length - 1);
                    Instantiate(Item, spawnSpots[randPos42].position, Quaternion.identity);
                    int randPos43 = Random.Range(0, spawnSpots.Length - 1);
                    Instantiate(Item, spawnSpots[randPos43].position, Quaternion.identity);
                    PowerUpTaken = false;
                }
                if (itemCount == 3 && PowerUpTaken == true)
                {
                    int randPos44 = Random.Range(0, spawnSpots.Length - 1);
                    Instantiate(Item, spawnSpots[randPos44].position, Quaternion.identity);
                    int randPos45 = Random.Range(0, spawnSpots.Length - 1);
                    Instantiate(Item, spawnSpots[randPos45].position, Quaternion.identity);
                    int randPos46 = Random.Range(0, spawnSpots.Length - 1);
                    Instantiate(Item, spawnSpots[randPos46].position, Quaternion.identity);
                    PowerUpTaken = false;
                }

                if (itemCount == 4 && PowerUpTaken == true)
                {
                    int randPos47 = Random.Range(0, spawnSpots.Length - 1);
                    Instantiate(Item, spawnSpots[randPos47].position, Quaternion.identity);
                    int randPos48 = Random.Range(0, spawnSpots.Length - 1);
                    Instantiate(Item, spawnSpots[randPos48].position, Quaternion.identity);
                    int randPos49 = Random.Range(0, spawnSpots.Length - 1);
                    Instantiate(Item, spawnSpots[randPos49].position, Quaternion.identity);
                    int randPos50 = Random.Range(0, spawnSpots.Length - 1);
                    Instantiate(Item, spawnSpots[randPos50].position, Quaternion.identity);
                    PowerUpTaken = false;
                }
            }
        }

        if (randNum2 == 2)
        {
            if (PowerUpTaken == true)
            {
                if (itemCount == 1 && PowerUpTaken == true)
                {
                    int randPos41 = Random.Range(0, spawnSpots.Length - 1);
                    Instantiate(Item3, spawnSpots[randPos41].position, Quaternion.identity);
                    PowerUpTaken = false;
                }

                if (itemCount == 2 && PowerUpTaken == true)
                {
                    int randPos42 = Random.Range(0, spawnSpots.Length - 1);
                    Instantiate(Item3, spawnSpots[randPos42].position, Quaternion.identity);
                    int randPos43 = Random.Range(0, spawnSpots.Length - 1);
                    Instantiate(Item3, spawnSpots[randPos43].position, Quaternion.identity);
                    PowerUpTaken = false;
                }
                if (itemCount == 3 && PowerUpTaken == true)
                {
                    int randPos44 = Random.Range(0, spawnSpots.Length - 1);
                    Instantiate(Item3, spawnSpots[randPos44].position, Quaternion.identity);
                    int randPos45 = Random.Range(0, spawnSpots.Length - 1);
                    Instantiate(Item3, spawnSpots[randPos45].position, Quaternion.identity);
                    int randPos46 = Random.Range(0, spawnSpots.Length - 1);
                    Instantiate(Item3, spawnSpots[randPos46].position, Quaternion.identity);
                    PowerUpTaken = false;
                }

                if (itemCount == 4 && PowerUpTaken == true)
                {
                    int randPos47 = Random.Range(0, spawnSpots.Length - 1);
                    Instantiate(Item3, spawnSpots[randPos47].position, Quaternion.identity);
                    int randPos48 = Random.Range(0, spawnSpots.Length - 1);
                    Instantiate(Item3, spawnSpots[randPos48].position, Quaternion.identity);
                    int randPos49 = Random.Range(0, spawnSpots.Length - 1);
                    Instantiate(Item3, spawnSpots[randPos49].position, Quaternion.identity);
                    int randPos50 = Random.Range(0, spawnSpots.Length - 1);
                    Instantiate(Item3, spawnSpots[randPos50].position, Quaternion.identity);
                    PowerUpTaken = false;
                }
            }
        }
    }
} 