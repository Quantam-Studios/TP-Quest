using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sickpeople : MonoBehaviour
{
    private float latestDirectionChangeTime;
    private readonly float directionChangeTime = 3f;
    public float characterVelocity = 100;
    private Vector2 movementDirection;
    private Vector2 movementPerSecond;

    public float zach;

    public Sprite one;
    public Sprite two;
    public Sprite three;
    public Sprite four;
    public Sprite five;
    public Sprite six;
    public Sprite seven;
    public Sprite eight;
    public float SlowedTime;
    public float DefaultSlowedTime;
    public static bool slowOrNot = false;
    public bool start = false;

    void Start()
    {
        latestDirectionChangeTime = 0f;
        calcuateNewMovementVector();
        slowOrNot = false;
        characterVelocity = 100;
        DefaultSlowedTime = SlowedTime;
        //Random sprite chosen from Sprites one=eight
        var randomInt = Random.Range(1, 8);
        zach = randomInt;
        if (zach == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = one;
        }
        if (zach == 2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = two;
        }
        if (zach == 3)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = three;
        }
        if (zach == 4)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = four;
        }
        if (zach == 5)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = five;
        }
        if (zach == 6)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = six;
        }
        if (zach == 7)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = seven;
        }
        if (zach == 8)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = eight;
        }
    }

    void calcuateNewMovementVector()
    {
        //create a random direction
        movementDirection = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)).normalized;
        movementPerSecond = movementDirection * characterVelocity;
    }

    void Update()
    {
        //if the changeTime was reached, calculate a new movement vector
        if (Time.time - latestDirectionChangeTime > directionChangeTime)
        {
            latestDirectionChangeTime = Time.time;
            calcuateNewMovementVector();

        }

        //once player hits safeZone on layer1 than start movement

        start = Timer.startTime;

        //if Player object hits a TimeFreeze make sick people and non sick speed slower
        if (slowOrNot == true)
        {
            calcuateNewMovementVector();
            characterVelocity = 0;
            SlowedTime -= 1 * Time.deltaTime;
        }
        else
        {
            characterVelocity = 100;
        }

        if (SlowedTime <= 0)
        {
            slowOrNot = false;
            characterVelocity = 100;
            calcuateNewMovementVector();
            SlowedTime = DefaultSlowedTime;
        }

        //move 
        transform.position = new Vector2(transform.position.x + (movementPerSecond.x * Time.deltaTime),
        transform.position.y + (movementPerSecond.y * Time.deltaTime));
    }

    void OnCollisionEnter2D(Collision2D something)
    {
        //Find new vector to move to
        if (something.collider.tag == "Wall")
        {
            calcuateNewMovementVector();
        }

        //Find new vector to move to
        if (something.collider.tag == "NPC")
        {
            calcuateNewMovementVector();
        }

        //Find new vector to move to
        if (something.collider.tag == "SafeZone")
        {
            calcuateNewMovementVector();
        }

    }


}


