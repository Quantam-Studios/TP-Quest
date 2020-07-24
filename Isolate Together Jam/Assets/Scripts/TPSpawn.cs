using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPSpawn : MonoBehaviour
{
    public GameObject Item;
    public GameObject Item2;
    public float itemCount;
    public Transform[] spawnSpots;
    public static bool TPTaken = false;

    void Start()
    {

        if (itemCount == 1)
        {
            int randPos = Random.Range(0, spawnSpots.Length - 1);
            Instantiate(Item, spawnSpots[randPos].position, Quaternion.identity);
        }

        if (itemCount == 2)
        {
            int randPos2 = Random.Range(0, spawnSpots.Length - 1);
            Instantiate(Item, spawnSpots[randPos2].position, Quaternion.identity);
            int randPos3 = Random.Range(0, spawnSpots.Length - 1);
            Instantiate(Item, spawnSpots[randPos3].position, Quaternion.identity);
        }
        if (itemCount == 3)
        {
            int randPos4 = Random.Range(0, spawnSpots.Length - 1);
            Instantiate(Item, spawnSpots[randPos4].position, Quaternion.identity);
            int randPos5 = Random.Range(0, spawnSpots.Length - 1);
            Instantiate(Item, spawnSpots[randPos5].position, Quaternion.identity);
            int randPos6 = Random.Range(0, spawnSpots.Length - 1);
            Instantiate(Item, spawnSpots[randPos6].position, Quaternion.identity);
        }

        if (itemCount == 4)
        {
            int randPos7 = Random.Range(0, spawnSpots.Length - 1);
            Instantiate(Item, spawnSpots[randPos7].position, Quaternion.identity);
            int randPos8 = Random.Range(0, spawnSpots.Length - 1);
            Instantiate(Item, spawnSpots[randPos8].position, Quaternion.identity);
            int randPos9 = Random.Range(0, spawnSpots.Length - 1);
            Instantiate(Item, spawnSpots[randPos9].position, Quaternion.identity);
            int randPos10 = Random.Range(0, spawnSpots.Length - 1);
            Instantiate(Item, spawnSpots[randPos10].position, Quaternion.identity);
        }
    }

    void Update()
    {
        int randInt = Random.Range(0, 6);
        if (randInt <= 4)
        {
            if (itemCount == 1 && TPTaken == true)
            {
                int randPos21 = Random.Range(0, spawnSpots.Length - 1);
                Instantiate(Item, spawnSpots[randPos21].position, Quaternion.identity);
                TPTaken = false;
            }

            if (itemCount == 2 && TPTaken == true)
            {
                int randPos22 = Random.Range(0, spawnSpots.Length - 1);
                Instantiate(Item, spawnSpots[randPos22].position, Quaternion.identity);
                int randPos23 = Random.Range(0, spawnSpots.Length - 1);
                Instantiate(Item, spawnSpots[randPos23].position, Quaternion.identity);
                TPTaken = false;
            }
            if (itemCount == 3 && TPTaken == true)
            {
                int randPos24 = Random.Range(0, spawnSpots.Length - 1);
                Instantiate(Item, spawnSpots[randPos24].position, Quaternion.identity);
                int randPos25 = Random.Range(0, spawnSpots.Length - 1);
                Instantiate(Item, spawnSpots[randPos25].position, Quaternion.identity);
                int randPos26 = Random.Range(0, spawnSpots.Length - 1);
                Instantiate(Item, spawnSpots[randPos26].position, Quaternion.identity);
                TPTaken = false;
            }

            if (itemCount == 4 && TPTaken == true)
            {
                int randPos27 = Random.Range(0, spawnSpots.Length - 1);
                Instantiate(Item, spawnSpots[randPos27].position, Quaternion.identity);
                int randPos28 = Random.Range(0, spawnSpots.Length - 1);
                Instantiate(Item, spawnSpots[randPos28].position, Quaternion.identity);
                int randPos29 = Random.Range(0, spawnSpots.Length - 1);
                Instantiate(Item, spawnSpots[randPos29].position, Quaternion.identity);
                int randPos30 = Random.Range(0, spawnSpots.Length - 1);
                Instantiate(Item, spawnSpots[randPos30].position, Quaternion.identity);
                TPTaken = false;
            }
        }
        if(randInt == 5)
        {
            if (itemCount == 1 && TPTaken == true)
            {
                int randPos21 = Random.Range(0, spawnSpots.Length - 1);
                Instantiate(Item2, spawnSpots[randPos21].position, Quaternion.identity);
                TPTaken = false;
            }

            if (itemCount == 2 && TPTaken == true)
            {
                int randPos22 = Random.Range(0, spawnSpots.Length - 1);
                Instantiate(Item2, spawnSpots[randPos22].position, Quaternion.identity);
                int randPos23 = Random.Range(0, spawnSpots.Length - 1);
                Instantiate(Item2, spawnSpots[randPos23].position, Quaternion.identity);
                TPTaken = false;
            }
            if (itemCount == 3 && TPTaken == true)
            {
                int randPos24 = Random.Range(0, spawnSpots.Length - 1);
                Instantiate(Item2, spawnSpots[randPos24].position, Quaternion.identity);
                int randPos25 = Random.Range(0, spawnSpots.Length - 1);
                Instantiate(Item2, spawnSpots[randPos25].position, Quaternion.identity);
                int randPos26 = Random.Range(0, spawnSpots.Length - 1);
                Instantiate(Item2, spawnSpots[randPos26].position, Quaternion.identity);
                TPTaken = false;
            }

            if (itemCount == 4 && TPTaken == true)
            {
                int randPos27 = Random.Range(0, spawnSpots.Length - 1);
                Instantiate(Item2, spawnSpots[randPos27].position, Quaternion.identity);
                int randPos28 = Random.Range(0, spawnSpots.Length - 1);
                Instantiate(Item2, spawnSpots[randPos28].position, Quaternion.identity);
                int randPos29 = Random.Range(0, spawnSpots.Length - 1);
                Instantiate(Item2, spawnSpots[randPos29].position, Quaternion.identity);
                int randPos30 = Random.Range(0, spawnSpots.Length - 1);
                Instantiate(Item2, spawnSpots[randPos30].position, Quaternion.identity);
                TPTaken = false;
            }
        }
    }
}
