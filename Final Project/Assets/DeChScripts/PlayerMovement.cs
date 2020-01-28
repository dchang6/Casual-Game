using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;

    void Awake()
    {
    }

    void FixedUpdate()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}