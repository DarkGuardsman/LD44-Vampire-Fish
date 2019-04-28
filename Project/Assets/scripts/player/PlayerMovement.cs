using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : PlayerFishComponent
{
    public float speed = 1f;
    
    void FixedUpdate()
    {
        //float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        //Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

        //Add force
        playerFish.rb2d.AddForce (transform.up * moveVertical * speed);
    }
}
