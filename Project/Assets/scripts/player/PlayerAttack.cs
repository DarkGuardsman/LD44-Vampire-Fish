using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {
    
    public TrackInArea areaOfAttack;
    public float damage = 10f;
	
    void FixedUpdate()
    {
		if (Input.GetMouseButtonDown(0))
        {
            //Copy list to prevent concurrent modifications
            List<GameObject> attackTargets = new List<GameObject>();
            attackTargets.AddRange(areaOfAttack.objectsInArea);
            
            //Loop targets
            foreach(GameObject target in attackTargets)
            {
                //Damage targets
                DamageData damageData = target.GetComponent<DamageData>();
                if(damageData != null)
                {
                    damageData.Attack(damage, gameObject);
                }
            }
        }
	}
}
