using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedIncreaser : MonoBehaviour {
	private Transform player;
	private Rigidbody rb;
	public GameObject[] Environment;
	private float forwardforce = 10f;
	public float variable = 1.0f;// initial multiplier of ground
	public float GroundLength = 71.0f; // this changes with code flow
	float initialLength;// this is going to stay as initial ground length throughout code
	int index0 = 0;// index of the Environment Array 
	float val1 = 0.2f;// distance by which obstacles or ground is increased
	int unknown = 0;//For the Distance Enhancing loop
	
	private void Start()
	{
		player = FindObjectOfType<PlayerMovement>().player;// gets player
		rb = FindObjectOfType<PlayerMovement>().rb;// gets rigidbody component of player
		initialLength = GroundLength;
	}
	public void FirstShift()
	{
		
		if (player.position.z < 300)
		{
								
			if (player.position.z < 150)
			{
				rb.AddForce(0, 0, forwardforce);
			}
			else {
				rb.AddForce(0, 0, forwardforce*1.1f);
			}                                                           // increments distance between
			
		}
		
	}
	public void SecondShift()
	{
		if (player.position.z < 1050 && player.position.z > 300)
		{
			
			if (player.position.z < 500) {
				rb.AddForce(0, 0, forwardforce * 1.2f);
			}
			else if (player.position.z < 750)
			{
				rb.AddForce(0, 0, forwardforce * 1.3f);
			}
			else
			{
				rb.AddForce(0, 0, forwardforce * 1.4f);
			}
			
		}
		while (unknown == 0)
		{
			if (player.position.z > 300)
			{
				Debug.Log("DistanceIncreasedSuccesfully");
				float val1 = 0.1f;
				variable += val1;
				float length = ((initialLength * (variable - 1)) / 2);
				GroundLength = initialLength * variable;
				FindObjectOfType<DistanceIncreased>().DistanceEnhance(variable - 1);
				for (index0 = 0; index0 < Environment.Length; index0++)
				{
					Environment[index0].transform.localScale += new Vector3(0, 0, variable - 1);
					Environment[index0].transform.position += new Vector3(0, 0, length);
				}
				unknown++;
			}
		}

	}
	public void ThirdShift()
	{
		if (player.position.z < 2250 && player.position.z > 1050)
		{
			
			if (player.position.z < 1400)
			{
				rb.AddForce(0, 0, forwardforce * 1.5f);
			}
			else if (player.position.z < 1800)
			{
				rb.AddForce(0, 0, forwardforce * 1.6f);
			}
			else
			{
				rb.AddForce(0, 0, forwardforce * 1.7f);
			}
			
		}
		while (unknown == 1)
		{
			if (player.position.z > 1050)
			{

				variable += val1;
				float length = ((initialLength * (variable - 1)) / 2);
				GroundLength = initialLength * variable;
				FindObjectOfType<DistanceIncreased>().DistanceEnhance(variable - 1);
				for (index0 = 0; index0 < Environment.Length; index0++)
				{
					Environment[index0].transform.localScale += new Vector3(0, 0, variable - 1);
					Environment[index0].transform.position += new Vector3(0, 0, length);
				}
				unknown++;

			}
		}
	}
	public void FourthShift()
	{
		if (player.position.z < 3900 && player.position.z > 2250)
		{
			
			if (player.position.z < 2750)
			{
				rb.AddForce(0, 0, forwardforce * 1.8f);
			}
			else if (player.position.z < 3300)
			{
				rb.AddForce(0, 0, forwardforce * 1.9f);
			}
			else
			{
				rb.AddForce(0, 0, forwardforce * 2.0f);
			}
			
		}
		while (unknown == 2)
		{
			if (player.position.z > 2250)
			{

				variable += val1;
				float length = ((initialLength * (variable - 1)) / 2);
				GroundLength = initialLength * variable;
				FindObjectOfType<DistanceIncreased>().DistanceEnhance(variable - 1);
				for (index0 = 0; index0 < Environment.Length; index0++)
				{
					Environment[index0].transform.localScale += new Vector3(0, 0, variable - 1);
					Environment[index0].transform.position += new Vector3(0, 0, length);
				}
				unknown++;
			}
		}

	}
	public void FifthShift()
	{
		if (player.position.z < 6000 && player.position.z > 3900)
		{
			
			if (player.position.z < 4550)
			{
				rb.AddForce(0, 0, forwardforce * 2.15f);
			}
			else if (player.position.z < 5250)
			{
				rb.AddForce(0, 0, forwardforce * 2.3f);
			}
			else
			{
				rb.AddForce(0, 0, forwardforce * 2.45f);
			}
			
		}
		while (unknown == 3)
		{
			if (player.position.z > 3900)
			{

				variable += val1;
				float length = ((initialLength * (variable - 1)) / 2);
				GroundLength = initialLength * variable;
				FindObjectOfType<DistanceIncreased>().DistanceEnhance(variable - 1);
				for (index0 = 0; index0 < Environment.Length; index0++)
				{
					Environment[index0].transform.localScale += new Vector3(0, 0, variable - 1);
					Environment[index0].transform.position += new Vector3(0, 0, length);
				}
				unknown++;

			}
		}

	}
	public void SixthShift()
	{
		if (player.position.z < 8550 && player.position.z > 6000)
		{
			if (player.position.z < 6800)
			{
				rb.AddForce(0, 0, forwardforce * 2.6f);
			}
			else if (player.position.z < 7650)
			{
				rb.AddForce(0, 0, forwardforce * 2.75f);
			}
			else
			{
				rb.AddForce(0, 0, forwardforce * 2.9f);
			}
			
		}
		while (unknown == 4)
		{
			if (player.position.z > 6000)
			{

				variable += val1;
				float length = ((initialLength * (variable - 1)) / 2);
				GroundLength = initialLength * variable;
				FindObjectOfType<DistanceIncreased>().DistanceEnhance(variable - 1);
				for (index0 = 0; index0 < Environment.Length; index0++)
				{
					Environment[index0].transform.localScale += new Vector3(0, 0, variable - 1);
					Environment[index0].transform.position += new Vector3(0, 0, length);
				}
				unknown++;
			}
		}
	}
	public void FinalShift()
	{
		if (player.position.z >8550)
		{
			rb.AddForce(0, 0, forwardforce * 3.0f);
			
		}
		while (unknown == 5)
		{
			if (player.position.z > 8550)
			{

				variable += val1;
				float length = ((initialLength * (variable - 1)) / 2);
				GroundLength = initialLength * variable;
				FindObjectOfType<DistanceIncreased>().DistanceEnhance(variable - 1);
				for (index0 = 0; index0 < Environment.Length; index0++)
				{
					Environment[index0].transform.localScale += new Vector3(0, 0, variable - 1);
					Environment[index0].transform.position += new Vector3(0, 0, length);
				}
				unknown++;
			}
		}
	}

}
