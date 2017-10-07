using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceIncreased : MonoBehaviour
{
	public GameObject[] obstacles;
	
	
	// here increment is how much we r multiplying the dist b/w obstacles
	public void DistanceEnhance(float increment)
	{
		Debug.Log("DistanceIncreserWorkingFine....!");
		Debug.Log("Current increment is ");
		Debug.Log(increment);
		int x = obstacles.Length;
		
		for (int i = 0; i < x -1; i++)
		{
			// distance of (i+1)th obstacle from 1st obstacle
			float length = obstacles[0].transform.position.z - obstacles[i + 1].transform.position.z;
			float onX = obstacles[i + 1].transform.position.x;
			float onY = obstacles[i + 1].transform.position.y;
			float onZ = obstacles[i + 1].transform.position.z + (length * increment);
			obstacles[i + 1].transform.position = new Vector3(onX, onY, onZ);
		}
	}
}
