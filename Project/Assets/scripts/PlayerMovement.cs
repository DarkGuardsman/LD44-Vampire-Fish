﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
    public float speed = 1f;
    
    private Rigidbody2D rb2d; 

   
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
    }
    
    void FixedUpdate()
    {
        //float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        //Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

        //Add force
        rb2d.AddForce (transform.up * moveVertical * speed);
    }
}
