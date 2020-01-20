using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;

public class LevelScreenToActualLevel : MonoBehaviour
{
    public float Timer;
    // Start is called before the first frame update
    void Start()
    {
        Timer = 0.0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Timer -= Time.deltaTime;

        if(Timer <=-3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Time.timeScale = 0;
        }
        
    }
}
