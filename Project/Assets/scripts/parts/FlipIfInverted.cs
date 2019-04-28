using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipIfInverted : MonoBehaviour {
    
    public SpriteRenderer spriteRenderer;
	
	// Update is called once per frame
	void Update () {
		float rotation = transform.eulerAngles.z;
        spriteRenderer.flipY = rotation < 0 || rotation > 180;
	}
}
