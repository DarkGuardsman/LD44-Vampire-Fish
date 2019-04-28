using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneDebugColor : MonoBehaviour 
{
    public Color gizmosColor = new Color(1, 0, 0, 0.5f);
    public Vector3 gizmosSize = new Vector3(1, 1, 1);
    
	void OnDrawGizmos() 
    {
        Gizmos.color = gizmosColor;
        Gizmos.matrix = transform.localToWorldMatrix;
        Gizmos.DrawCube(Vector3.zero, gizmosSize);
    }
}
