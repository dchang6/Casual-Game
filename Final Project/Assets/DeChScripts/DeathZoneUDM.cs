using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class DeathZoneUDM : MonoBehaviour
{
 
    public float distance;
    public float linearSpeed;
    private Rigidbody2D rgb2d;
    private float startPosition;
    public float speed = 1.5f;
 
    void Start()
    {
        rgb2d = GetComponent<Rigidbody2D>();
        startPosition = rgb2d.position.y;
    }
 
    private void FixedUpdate()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
        transform.position += Vector3.down * speed * Time.deltaTime;
        rgb2d.SetRotation(rgb2d.rotation * Time.fixedDeltaTime);
        rgb2d.MovePosition(new Vector2((Mathf.Sin((2 * Mathf.PI * (Time.time*linearSpeed/distance)) - (Mathf.PI / 2)) * (distance/2) + (distance/2))+startPosition,rgb2d.position.y));
    }
}
