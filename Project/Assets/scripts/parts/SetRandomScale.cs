using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRandomScale : MonoBehaviour 
{
    public float scaleMinY = 0.2f;
    public float scaleMaxY = 0.2f;
    
    public float scaleMinX = 0.2f;
    public float scaleMaxX = 0.2f;
    
	// Use this for initialization
	void Start () 
    {
        gameObject.transform.localScale += new Vector3(Random.Range(-scaleMinX, scaleMaxX), Random.Range(-scaleMinY, scaleMaxY), 0);
        
		//Disable as this only runs once
        enabled = false;
	}
}
