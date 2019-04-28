using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : UIDisplay 
{
     public DamageData damageData;
    
    public Text healthText;
    
    public Image healthImage;
    
    private float healthWidth;
    
    void Start()
    {
        healthWidth = healthImage.rectTransform.sizeDelta.x;
    }
	
	// Update is called once per frame
	void Update () 
    {
        if(gameController.currentPlayerObject != null && damageData == null)
        {
            damageData = gameController.currentPlayerObject.GetComponent<DamageData>();
        }
        if(damageData != null)
        {
            if(healthText != null)
            {
                healthText.text = damageData.health + "/" + damageData.maxHealth;
            }
            
            if(healthImage != null)
            {            
                float hpSize = getSize(healthWidth, damageData.health, damageData.maxHealth);
                healthImage.rectTransform.sizeDelta = new Vector2(hpSize, healthImage.rectTransform.sizeDelta.y);
            }
            handleBar(healthImage, healthWidth, damageData.health, damageData.maxHealth);
        }
        else if(healthText != null)
        {
            healthText.text = "Err";
        }
	}
    
    private void handleBar(Image image, float normal, float hp, float maxHp)
    {
        if(image != null)
        { 
            float size = getSize(normal, hp, maxHp);
            if(size > 0)
            {
                image.gameObject.SetActive(true);
                image.rectTransform.sizeDelta = new Vector2(size, image.rectTransform.sizeDelta.y);
            }
            else
            {
                image.gameObject.SetActive(false);
            }
        }           
    }
    
    private float getSize(float normal, float hp, float maxHp)
    {        
        return Mathf.Min(normal, Mathf.Max(0, normal * (hp / maxHp)));
    }
}
