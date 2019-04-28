using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchPosition : MonoBehaviour {

    public Transform target;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 position = transform.position;
		position.x = target.position.x;
        position.y = target.position.y;
        
        transform.position = position;
	}
}
