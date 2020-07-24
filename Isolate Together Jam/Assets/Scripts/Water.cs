using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Water : MonoBehaviour
{
    void Start()
    {
        gameObject.layer = 9;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Player")
        {
            if (ItemOnOff.SoundEffects == false)
            {
                FindObjectOfType<AudioManager>().Play("Drip");
            }
            ThirstBar.Thirst += 25;
            WaterSpawn.waterTaken = true;
            Destroy(gameObject);
        }

        if (col.collider.tag == "Dog")
        {
            if (ItemOnOff.SoundEffects == false)
            {
                FindObjectOfType<AudioManager>().Play("Drip");
            }
            ThirstBar.Thirst += 25;
            WaterSpawn.waterTaken = true;
            Destroy(gameObject);
        }
    }
}
