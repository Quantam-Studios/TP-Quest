using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenTP : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Player")
        {
            TPCounter.TP += 60;
            if (ItemOnOff.SoundEffects == false)
            {
                FindObjectOfType<AudioManager>().Play("Angel");
            }
            TPSpawn.TPTaken = true;
            Destroy(gameObject);
        }

        if (col.collider.tag == "Dog")
        {
            TPCounter.TP += 60;
            if (ItemOnOff.SoundEffects == false)
            {
                FindObjectOfType<AudioManager>().Play("Angel");
            }
            TPSpawn.TPTaken = true;
            Destroy(gameObject);
        }
    }
}
