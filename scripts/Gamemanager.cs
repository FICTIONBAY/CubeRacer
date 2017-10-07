using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour {

	
	public GameObject gameover;
	public float delaytime = 2f;
	bool gameEnded = false;
	public void Gameover()
	{
		if(gameEnded== false)
		{
			Invoke("GameOver", 0.3f);
			gameEnded = true;
			
		}
	}
	public void Restart()
	{
		int x = 0;
		 List<GameObject> remainingAreas;// leftover areas on screen after gameover
		GameObject[] enhancedEnvironments;// enhanced environments at the tym of gameover
		enhancedEnvironments = FindObjectOfType<SpeedIncreaser>().Environment;
		for (x = 0; x < enhancedEnvironments.Length; x++)
		{
			enhancedEnvironments[x].transform.localScale = new Vector3(1, 1, 1);// back to normal
			enhancedEnvironments[x].transform.position = new Vector3(0, 0, 0);
		}

		remainingAreas = FindObjectOfType<LevelExtender>().activeAreas;
		for(x=0;x<remainingAreas.Count ; x++)
		{
			FindObjectOfType<LevelExtender>().DeleteArea();
		}
		
	
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
	private void GameOver()
	{
		gameover.SetActive(true);
	}
}
