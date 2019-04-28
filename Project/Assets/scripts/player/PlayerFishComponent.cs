using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFishComponent : MonoBehaviour {
    public PlayerFish playerFish;
    
	void Start () {
        playerFish = GetComponent<PlayerFish>();
	}
    
    public void ConsumeBlood(float blood, string reason)
    {
        playerFish.ConsumeBlood(blood, reason);
    }
}
