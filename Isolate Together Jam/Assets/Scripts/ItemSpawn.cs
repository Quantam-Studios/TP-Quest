using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawn : MonoBehaviour
{
    public GameObject Item;
    public float itemCount;
    public Transform[] spawnSpots;
    public static bool foodTaken = false;
    public static bool waterTaken = false;

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
        if (itemCount == 1 && foodTaken == true)
        {
            int randPos11 = Random.Range(0, spawnSpots.Length - 1);
            Instantiate(Item, spawnSpots[randPos11].position, Quaternion.identity);
            foodTaken = false;
        }

        if (itemCount == 2 && foodTaken == true)
        {
            int randPos12 = Random.Range(0, spawnSpots.Length - 1);
            Instantiate(Item, spawnSpots[randPos12].position, Quaternion.identity);
            int randPos13 = Random.Range(0, spawnSpots.Length - 1);
            Instantiate(Item, spawnSpots[randPos13].position, Quaternion.identity);
            foodTaken = false;
        }
        if (itemCount == 3 && foodTaken == true)
        {
            int randPos14 = Random.Range(0, spawnSpots.Length - 1);
            Instantiate(Item, spawnSpots[randPos14].position, Quaternion.identity);
            int randPos15 = Random.Range(0, spawnSpots.Length - 1);
            Instantiate(Item, spawnSpots[randPos15].position, Quaternion.identity);
            int randPos16 = Random.Range(0, spawnSpots.Length - 1);
            Instantiate(Item, spawnSpots[randPos16].position, Quaternion.identity);
            foodTaken = false;
        }

        if (itemCount == 4 && foodTaken == true)
        {
            int randPos17 = Random.Range(0, spawnSpots.Length - 1);
            Instantiate(Item, spawnSpots[randPos17].position, Quaternion.identity);
            int randPos18 = Random.Range(0, spawnSpots.Length - 1);
            Instantiate(Item, spawnSpots[randPos18].position, Quaternion.identity);
            int randPos19 = Random.Range(0, spawnSpots.Length - 1);
            Instantiate(Item, spawnSpots[randPos19].position, Quaternion.identity);
            int randPos20 = Random.Range(0, spawnSpots.Length - 1);
            Instantiate(Item, spawnSpots[randPos20].position, Quaternion.identity);
            foodTaken = false;
        }
    }

}
