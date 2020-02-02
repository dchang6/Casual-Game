using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeChPlayerController : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public static int timeLeft;
    public float Score;
    public Text timeText;
    private int wholeTime;
    public Text gameoverText;
    
    

    void Start()
    {
        StartCoroutine(ByeAfterDelay(2));
        rb2d = GetComponent<Rigidbody2D>();
        Score =0.0f;
        gameoverText.text = "";
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        { 
            gameObject.GetComponent<Renderer>().material.color = Color.black;
            gameoverText.text = "Game Over!";
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }
        
        if (other.gameObject.tag == "DEATH")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.black;
            gameoverText.text = "Game Over!";
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }
    }

    void FixedUpdate()
    {
    }


        void Update()
    {
        Score += Time.deltaTime; 
        wholeTime = (int) Score;
        timeText.text = "Score: "+ wholeTime;
    }

    IEnumerator ByeAfterDelay(float time)
    {
        yield return new WaitForSeconds(time);
    }
}