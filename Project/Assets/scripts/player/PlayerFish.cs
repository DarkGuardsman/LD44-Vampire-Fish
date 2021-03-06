﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFish : MonoBehaviour {
    
    public DamageData damageData;
    public Rigidbody2D rb2d; 
    public float idleBloodCost = 0.1f;
    
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
        damageData = GetComponent<DamageData>();
    }
    
	void FixedUpdate () {
		ConsumeBlood(idleBloodCost, "IdleCost");
	}
    
    public void ConsumeBlood(float blood, string reason)
    {
        damageData.RemoveHealth(blood, reason); //TODO display death reason
    }
}
