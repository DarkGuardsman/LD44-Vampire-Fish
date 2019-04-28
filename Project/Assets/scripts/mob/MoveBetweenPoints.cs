using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class MoveBetweenPoints : MonoBehaviour {

    public Transform targetA;
    public Transform targetB;
    public float switchDistance = 0.5f;
    public bool moveToA = true;
    
    IAstarAI ai;

    void OnEnable () {
        ai = GetComponent<IAstarAI>();
        if (ai != null) ai.onSearchPath += Update;
    }

    void OnDisable () {
        if (ai != null) ai.onSearchPath -= Update;
    }

    /// <summary>Updates the AI's destination every frame</summary>
    void Update () {
        if (ai != null) 
        {
            //Check if we need to switch targets
            float distance = 0;
            if(moveToA)
            {
                distance = Vector3.Distance(targetA.position, transform.position);
                if(distance <= switchDistance)
                {
                    moveToA = false;
                }
            }
            else
            {
                distance = Vector3.Distance(targetB.position, transform.position);
                if(distance <= switchDistance)
                {
                    moveToA = true;
                }
            }
            
            //Update target
            ai.destination = moveToA ? targetA.position : targetB.position;
        }
    }
}
