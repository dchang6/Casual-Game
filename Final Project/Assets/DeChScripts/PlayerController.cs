using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

  public float jumpSpeed = 1f;
  private float movement = 0f;
  private Rigidbody2D rigidBody;

  // Use this for initialization
  void Start () {
    rigidBody = GetComponent<Rigidbody2D> ();
  }
  
  // Update is called once per frame
  void Update () {
    movement = Input.GetAxis ("Horizontal");
    if(Input.GetKeyDown ("o")){
      rigidBody.velocity = new Vector2(rigidBody.velocity.x,jumpSpeed);
    }
  }
}