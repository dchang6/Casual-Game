using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;

public class MenuStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p") || (Input.GetButtonDown(buttonName: "Menu")))
        {
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }
    }
}