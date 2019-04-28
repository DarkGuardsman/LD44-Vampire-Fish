using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageData : MonoBehaviour {

    public float health = -1;
    public float maxHealth = 10f;
    
    public bool dead = false;
    public bool destroyOnDeath = true;
    
    public GameObject prefabToSpawnOnDeath;
    
	// Use this for initialization
	public virtual void Start () 
    {
		if(health <= 0)
        {
            health = maxHealth;
        }
	}
    
    public void Attack(float damage, GameObject source)
    {
        Debug.Log("DamageData: Object hit with '" + damage + "' damage from source '" + source +"'");
        
        if(damage > 0)
        {
            health -= damage;
            
            OnAttacked(damage, source);
            
            if(health <= 0)
            {
                SetDead();
            }
        }
    }
    
    public void RemoveHealth(float hp, string reason)
    {
        health -= hp;
        if(health <= 0)
        {
            SetDead();
        }
    }
    
    public void addHealth(float hp)
    {
        health += hp;
        health = Mathf.Min(maxHealth, health);
        health = Mathf.Max(0, health);
    }
    
    protected virtual void OnAttacked(float damage, GameObject source)
    {
        
    }
    
    public void SetDead()
    {
        Debug.Log("DamageData: Setting host dead '" + gameObject + "'");
        dead = true;
         
        OnDeath();
        
        if(destroyOnDeath)
        {
            Destroy(gameObject);
        }
    }
    
    protected virtual void OnDeath()
    {
        if(prefabToSpawnOnDeath != null)
        {
            Instantiate(prefabToSpawnOnDeath, transform.position, transform.rotation);
        }
    }
}
