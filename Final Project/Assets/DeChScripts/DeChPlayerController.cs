using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeChPlayerController : MonoBehaviour
{
    public KeyCode moveRight;
    private Rigidbody2D rb2d;
    private int GameLoader;
    public static bool gameOn;
    public static int timeLeft;
    public Text winText;
    public float Timer;
    public Text timeText;
    private int wholeTime;
    public Text loseText;
    public Text scoreText;
    private static int score;

    void Start()
    {
        StartCoroutine(ByeAfterDelay(2));
        rb2d = GetComponent<Rigidbody2D>();
        winText.text = "";
        Timer =0.0f;
        loseText.text = "";
        scoreText.text = "";
    }

    void OnCollisionEnter2D(Collision2D col)
    {

        Debug.Log("collision name = " + col.gameObject.name);
        if (col.collider.tag == "Enemy")
        { 
            loseText.text = "You lose!";
            gameObject.GetComponent<Renderer>().material.color = Color.black;
            StartCoroutine(ByeAfterDelay(2));
            Destroy(GameObject.FindWithTag("Enemy"), 2f);
            Time.timeScale = 0;
        }
    }

    void FixedUpdate()
    {
        {
            scoreText.text = "Points: " + wholeTime;
        }

        if (Timer >= 10)
        {
            winText.text = "You Win!";
            Destroy(GameObject.FindWithTag("Enemy"), 0.01f);
           Time.timeScale = 0;
        }
    }


        void Update()
    {
        Timer += Time.deltaTime; 
        wholeTime = (int) Timer;
        timeText.text = "Timer: "+ wholeTime;

        if (Input.GetKeyDown(moveRight))
                GetComponent<Rigidbody2D>().velocity = new Vector3(14, 0, 0);

        
        //GameLoader.AddScore(wholeTime);

            if (Input.GetKey("escape"))
                Application.Quit();

    }

    IEnumerator ByeAfterDelay(float time)
    {
        yield return new WaitForSeconds(time);
    }
}