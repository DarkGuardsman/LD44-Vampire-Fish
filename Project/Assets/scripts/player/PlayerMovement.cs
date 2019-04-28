using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : PlayerFishComponent
{
    public float speed = 1f;
    public float bloodCost = 0.1f;
    
    void FixedUpdate()
    {
        //Get Movement
        float moveVertical = Input.GetAxis ("Vertical");
        
        //Consume blood for moving
        float blood = bloodCost * Mathf.Abs(moveVertical);
        ConsumeBlood(blood, "Movement");

        //Add force
        playerFish.rb2d.AddForce (transform.up * moveVertical * speed);
    }
}
