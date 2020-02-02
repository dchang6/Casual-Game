﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class DeathZoneBFM : MonoBehaviour
{
 
    public float distance;
    public float linearSpeed;
    private Rigidbody2D rgb2d;
    private float startPosition;
 
    void Start()
    {
        rgb2d = GetComponent<Rigidbody2D>();
        startPosition = rgb2d.position.x;
    }
 
    private void FixedUpdate()
    {
        rgb2d.SetRotation(rgb2d.rotation * Time.fixedDeltaTime);
        rgb2d.MovePosition(new Vector2((Mathf.Sin((2 * Mathf.PI * (Time.time*linearSpeed/distance)) - (Mathf.PI / 2)) * (distance/2) + (distance/2))+startPosition,rgb2d.position.y));
    }
}