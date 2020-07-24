using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Book : MonoBehaviour
{

    void Start()
    {
        gameObject.layer = 9;

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Player")
        {
            BoredomBar.boredom += 25;
            if (ItemOnOff.SoundEffects == false)
            {
                FindObjectOfType<AudioManager>().Play("Book");
            }

            BookSpawn.bookTaken = true;
            Destroy(gameObject);
        }

        if (col.collider.tag == "Dog")
        {
            BoredomBar.boredom += 25;
            if (ItemOnOff.SoundEffects == false)
            {
                FindObjectOfType<AudioManager>().Play("Book");
            }
            BookSpawn.bookTaken = true;
            Destroy(gameObject);
        }
    }
}
