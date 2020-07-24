using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static float speed = 100;
    public Sprite sick;
    public Sprite Healthy;
    public GameObject GameOverMenu;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    public static bool GameOver = false;
    public float GoalTime;
    public float SetTime;
    public bool GotVaccine = false;
    public static bool Slow = false;
    public float Norm;

    //powered by vaccine
    public Sprite one;
    public Sprite two;
    public Sprite three;
    public Sprite four;
    public Sprite five;
    public Sprite six;
    public Sprite seven;
    public Sprite eight;
    public Sprite nine;
    public Sprite ten;
    public Sprite eleven;
    public Sprite twelve;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GameOver = false;
        GotVaccine = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;
        if (GotVaccine == true)
        {
            gameObject.layer = 14;
            GoalTime -= Time.deltaTime;

            if (GoalTime >= 12 && GoalTime <= 15)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = one;
            }
            if (GoalTime >= 11 && GoalTime < 12)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = two;
            }
            if (GoalTime >= 10 && GoalTime < 11)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = three;
            }
            if (GoalTime >= 9 && GoalTime < 10)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = four;
            }
            if (GoalTime >= 8 && GoalTime < 9)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = five;
            }
            if (GoalTime >= 7 && GoalTime < 8)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = six;
            }
            if (GoalTime >= 6 && GoalTime < 7)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = seven;
            }
            if (GoalTime >= 5 && GoalTime < 6)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = eight;
            }
            if (GoalTime >= 4 && GoalTime < 5)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = nine;
            }
            if (GoalTime >= 3 && GoalTime < 4)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = ten;
            }
            if (GoalTime >= 2 && GoalTime < 3)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = eleven;
            }
            if (GoalTime > 0 && GoalTime < 2)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = twelve;
            }
            if (GoalTime <= 0)
            {
                GotVaccine = false;
                gameObject.layer = 13;
                GoalTime = SetTime;
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Healthy;
            }
        }

        if (Slow == true)
        {
            Norm -= Time.deltaTime;
            if(Norm <= 0)
            {
                Slow = false;
            }
        }
    }


    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.collider.tag == "NPC")
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = sick;
            Time.timeScale = 0;
            FinalScore.TimeScore = Timer.Score;
            FinalScore.tpscore = TPCounter.TPScore;
            TimeScore.FinalTime = Timer.Score;
            FinalTP.TPFinal = TPCounter.TPScore;
            GameOverMenu.SetActive(true);
            GameOver = true;
            if (Timer.Score >= Timer.HighScore)
            {
                Timer.HighScore = Timer.Score;
            }
            if (TPCounter.TPScore >= TPCounter.TPHighScore)
            {
                TPCounter.TPHighScore = TPCounter.TPScore;
            }
        }

        if (col.collider.tag == "books")
        {
           BookCounter.books += 1;
        }

        if (col.collider.tag == "Vaccine")
        {
            GotVaccine = true;
        }
        if(col.collider.tag == "SafeZone")
        {
            Timer.startTime = true;
        }
    }
}
