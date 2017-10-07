using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
	public Transform player;
	private float forwardforce = 10f;
	private float sidewardforce = 50f;
	// Use this for initialization
	void Start () {
		Debug.Log("GameStartedSuccesfully..!");		
	}
	
	// Update is called once per frame
	public void FixedUpdate () {
		if (Input.GetKey("d")|| Input.GetKeyDown("d"))
		{
			rb.AddForce(sidewardforce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
		}
		if (Input.GetKey("a")|| Input.GetKeyDown("a"))
		{
			rb.AddForce(-sidewardforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		if (Input.GetKey("w") || Input.GetKeyDown("w"))
		{
			rb.AddForce(0, 0, forwardforce * Time.deltaTime, ForceMode.VelocityChange);
		}
		



	}
	 void Update()
	{
		if (player.position.z < 300)
		{ FindObjectOfType<SpeedIncreaser>().FirstShift(); }

		if (player.position.z < 1050 && player.position.z > 300)
		{ FindObjectOfType<SpeedIncreaser>().SecondShift(); }

		if (player.position.z < 2250 && player.position.z > 1050)
		{ FindObjectOfType<SpeedIncreaser>().ThirdShift(); }

		if (player.position.z < 3900 && player.position.z > 2250)
		{ FindObjectOfType<SpeedIncreaser>().FourthShift(); }

		if (player.position.z < 6000 && player.position.z > 3900)
		{ FindObjectOfType<SpeedIncreaser>().FifthShift(); }

		if (player.position.z < 8550 && player.position.z > 6000)
		{ FindObjectOfType<SpeedIncreaser>().SixthShift(); }

		if (player.position.z > 8550)
		{ FindObjectOfType<SpeedIncreaser>().FinalShift(); };
	}
	
}
