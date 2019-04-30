using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishDamageData : DamageData {

	public float bloodDropChange = 1f;
    public float bloodDropAmount = 1f;
    public float bloodDropPercentage = 1f;
    
    public GameObject prefabBloodDrops;
    
    public  AudioSource audioData;
    
    protected override void OnAttacked(float damage, GameObject source)
    {
        if(damage > 0)
        {
            //Play damage audio
            if(audioData != null)
            {
                audioData.Play(0);
            }
             
            if(prefabBloodDrops != null)
            {
                //Calculate blood drops to spawn
                int dropCount = (int)Mathf.Max(1, (bloodDropPercentage * damage) / bloodDropAmount);
                
                //Loop to create blood drops
                for(int i = 0; i < dropCount; i++)
                {
                    if(Random.Range(0, 1) <= bloodDropChange)
                    {
                        GameObject spawned = Instantiate(prefabBloodDrops, transform.position, transform.rotation);
                        
                        //Ignore collision of self
                        Physics2D.IgnoreCollision(spawned.GetComponent<Collider2D>(), GetComponent<Collider2D>());
                        
                        //Set hp of blood drop
                        DamageData damageData = spawned.GetComponent<DamageData>();
                        if(damageData != null)
                        {
                            damageData.health = bloodDropAmount;
                            damageData.maxHealth = bloodDropAmount;
                        }
                    }
                }
            }
        }
    }
}
