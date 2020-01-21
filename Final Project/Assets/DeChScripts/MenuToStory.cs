using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;

public class MenuToStory : MonoBehaviour
{
    public float LTimer;
    // Start is called before the first frame update
    void Start()
    {
        LTimer = 0.0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        LTimer -= Time.deltaTime;

        if (LTimer <= -12)
        {
            SceneManager.LoadScene("Story", LoadSceneMode.Single);
            Time.timeScale = 0;
        }

    }
}
