using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour {

    public Transform targetA;
    public Transform targetB;
    
    public float rotationOffset = 90;
    
    public GameObject prefabToSpawn;
    
	// Use this for initialization
	void Start () 
    {
		GameObject fish = Instantiate(prefabToSpawn, transform.position, Quaternion.Euler(0, 0, rotationOffset));
        MoveBetweenPoints moveBetweenPoints = fish.GetComponent<MoveBetweenPoints>();
        if(moveBetweenPoints != null)
        {
            moveBetweenPoints.targetA = targetA;
            moveBetweenPoints.targetB = targetB;
        }
	}
}
