using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour {

    public Transform targetA;
    public Transform targetB;
    
    public float rotationOffset = 90;
    
    public GameObject[] prefabToSpawns;
	
	public GameObject currentFish;
	public float respawnTimer = 0;
	public float respawnDelay = 10f;
    
	public void FixedUpdate()
	{
		if(currentFish == null)
		{
			respawnTimer -= Time.fixedDeltaTime;
			if(respawnTimer <= 0)
			{
				spawnFish();
				respawnTimer = respawnDelay;
			}
		}
	}
	
	public void spawnFish()
    {
        GameObject prefabToSpawn = prefabToSpawns[Random.Range(0, prefabToSpawns.Length)];
		//create new fish
		currentFish = Instantiate(prefabToSpawn, transform.position, Quaternion.Euler(0, 0, rotationOffset));
        
		//Setup waypoints
		MoveBetweenPoints moveBetweenPoints = currentFish.GetComponent<MoveBetweenPoints>();
        if(moveBetweenPoints != null)
        {
            moveBetweenPoints.targetA = targetA;
            moveBetweenPoints.targetB = targetB;
        }
	}
}
