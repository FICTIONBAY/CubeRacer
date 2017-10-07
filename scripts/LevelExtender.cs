using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelExtender : MonoBehaviour {

	public GameObject[] areaPrefabs;
	public Transform playerTransform;
	public  float spawnZ = 0.0f;//initial position to add level
	public float areaLength=71.0f; // initial length of each  Ground area
	int nolos = 5;//no.of levels on screen
	public List<GameObject> activeAreas;// to destroy created levels
	// Use this for initialization
	public void Start () {
		activeAreas = new List<GameObject>();
		
		LevelExtend(5);
		for(int i=0; i<nolos; i++)
		{
			int randomIndex = Random.Range(0, areaPrefabs.Length);
			LevelExtend(randomIndex);
		}
	}
	
	// Update is called once per frame
	public void Update () {
		if (playerTransform.position.z-areaLength > (spawnZ - (nolos * areaLength)))// i used 71 to be in safe zone to delete the last area
		{
			int randomIndex = Random.Range(0, areaPrefabs.Length);
			LevelExtend(randomIndex);
			DeleteArea();
			Debug.Log(spawnZ);

		}
	}
	private void LevelExtend(int i)
	{
		GameObject go;
		go = Instantiate(areaPrefabs[i]) as GameObject;
		
		Debug.Log("position of new area on z ");
		Debug.Log(spawnZ);
		if (i == 1)
		{
			go.transform.SetParent(transform);
			Vector3 pos = new Vector3(0.0f, 0.0f, 40.5f+spawnZ);
			go.transform.position = pos;
			spawnZ += areaLength;
		}
		if (i == 0)
		{
			go.transform.SetParent(transform);
			Vector3 pos = new Vector3(0.0f,0.0f,40.5f+ spawnZ);
			go.transform.position = pos;
			spawnZ += areaLength;
		}
		if (i == 2)
		{
			go.transform.SetParent(transform);
			Vector3 pos = new Vector3(0.0f,1.0f,40.5f+ spawnZ);
			go.transform.position = pos;
			spawnZ += areaLength;
		}
		if (i == 3)
		{
			go.transform.SetParent(transform);
			Vector3 pos = new Vector3(0.0f,0.0f,40.5f+ spawnZ);
			go.transform.position = pos;
			spawnZ += areaLength;
		}
		if (i == 4)
		{
			go.transform.SetParent(transform);
			Vector3 pos = new Vector3(0.0f, 1.0f, 40.5f+ spawnZ);
			go.transform.position = pos;
			spawnZ += areaLength;
		}
		if (i == 5)
		{
			go.transform.SetParent(transform);
			Vector3 pos = new Vector3(0.0f, 0.0f, 40.5f + spawnZ);
			go.transform.position = pos;
			spawnZ += areaLength;
		}
		activeAreas.Add(go);// adds to the list
	}
	public void DeleteArea()
	{
		Destroy(activeAreas[0]);
		activeAreas.RemoveAt(0);
		
	}
	
}
