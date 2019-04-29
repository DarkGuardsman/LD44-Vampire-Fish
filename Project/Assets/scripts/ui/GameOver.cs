using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : UIDisplay {
	
	public GameObject gameOverUI;
	
	// Update is called once per frame
	void Update () 
	{
		gameOverUI.SetActiveStateIfNot(gameController.currentPlayerObject == null);
	}
	
	public void restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
	
	public void exit()
	{
		Application.Quit();
	}
}
