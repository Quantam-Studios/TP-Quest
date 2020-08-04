using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static float speed = 125;
    public Sprite sick;
    public Sprite Healthy;
    public GameObject GameOverMenu;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    public static bool GameOver = false;
    public float GoalTime;
    public float SetTime;
    public bool GotVaccine = false;
    public Color SickCol;
    public static GameObject Dog;
    public GameObject DogOBJ;
    public GameObject Collider;

    //Customization
    public GameObject HeadColor;
    public GameObject JacketColor;
    public GameObject ShirtColor;
    public GameObject PantsColor;
    public GameObject Face;
    public Sprite SickFace;

    public GameObject PowerUpTimer;

    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        PowerUpTimer.SetActive(false);
        Dog = DogOBJ;
        Collider.layer = 13;
        GameOver = false;
        GotVaccine = false;
        HeadColor.GetComponent<SpriteRenderer>().color = PlayerCustomization.TrueFaceCol[PlayerCustomization.FaceActive];
        JacketColor.GetComponent<SpriteRenderer>().color = PlayerCustomization.TrueJacketCol[PlayerCustomization.JacketActive];
        ShirtColor.GetComponent<SpriteRenderer>().color = PlayerCustomization.TrueShirtCol[PlayerCustomization.ShirtActive];
        PantsColor.GetComponent<SpriteRenderer>().color = PlayerCustomization.TruePantsCol[PlayerCustomization.PantsActive];
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;
        if (GotVaccine == true)
        {
            gameObject.layer = 14;
            Collider.layer = 14;
            GoalTime -= Time.deltaTime;

            if (GoalTime <= 0)
            {
                GotVaccine = false;
                gameObject.layer = 13;
                Collider.layer = 13;
                GoalTime = SetTime;
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
            HeadColor.GetComponent<SpriteRenderer>().color = SickCol;
            Face.GetComponent<SpriteRenderer>().sprite = SickFace;
            Debug.Log("SICK");
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
            PowerUpTimer.SetActive(true);
            PowerUpTracker.CurrentPower = 0;
            PowerUpTracker.time2 = SetTime;
        }

        if (col.collider.tag == "TimeFreeze")
        {
            PowerUpTimer.SetActive(true);
            PowerUpTracker.CurrentPower = 1;
            PowerUpTracker.time2 = 10;
        }

        if (col.collider.tag == "PetDog")
        {
            PowerUpTimer.SetActive(true);
            PowerUpTracker.CurrentPower = 2;
            PowerUpTracker.time2 = 15;
        }

        if (col.collider.tag == "SafeZone")
        {
            Timer.startTime = true;
        }
    }
}
