using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodDrop : MonoBehaviour {

    public DamageData damageData;
    
	// Use this for initialization
	void Start () {
		damageData = GetComponent<DamageData>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    void OnCollisionEnter2D(Collision2D col)
    {
        GameObject other = col.gameObject;
        if(other.name == "Player")
        {
            DamageData playerDamage = other.GetComponent<DamageData>();
            if(playerDamage != null)
            {
                playerDamage.addHealth(damageData.health);
                Destroy(gameObject);
            }
        }
    }
}
