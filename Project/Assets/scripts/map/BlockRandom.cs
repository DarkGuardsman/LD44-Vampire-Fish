using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockRandom : MonoBehaviour {
    
    public SpriteRenderer[] blocks;
    
    public Sprite[] textures;

	// Use this for initialization
	void Start () {
		for(int i = 0; i < blocks.Length; i++)
        {
            blocks[i].sprite = textures[Random.Range(0, textures.Length)];
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
