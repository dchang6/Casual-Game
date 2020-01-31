using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeChPlayerController : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private int GameLoader;
    public static bool gameOn;
    public static int timeLeft;
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

        Debug.Log("collision name = " + col.gameObject.name);
        if (col.collider.tag == "Death")
        {
            loseText.text = "You lose!";
            gameObject.GetComponent<Renderer>().material.color = Color.black;
            StartCoroutine(ByeAfterDelay(2));
            Destroy(GameObject.FindWithTag("Player"), 2f);
            Time.timeScale = 0;
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }
    }

    void FixedUpdate()
    {
        {
            scoreText.text = "Timer: " + wholeTime;
        }
    }


        void Update()
    {
        Timer += Time.deltaTime; 
        wholeTime = (int) Timer;
        timeText.text = "Timer: "+ wholeTime;

            if (Input.GetKey("escape"))
                Application.Quit();

    }

    IEnumerator ByeAfterDelay(float time)
    {
        yield return new WaitForSeconds(time);
    }
}