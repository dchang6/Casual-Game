using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;

public class StorytoMenu : MonoBehaviour
{
    public float PTimer;
    // Start is called before the first frame update
    void Start()
    {
        PTimer = 0.0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PTimer -= Time.deltaTime;

        if (PTimer <= -12)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Time.timeScale = 0;
        }

    }
}
