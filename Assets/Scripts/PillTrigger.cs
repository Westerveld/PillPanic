using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class PillTrigger : MonoBehaviour
{

	public PillType myPill;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		

	}

	void OnCollisionStay(Collision col)
	{
		if (col.gameObject.tag == "Player")
		{
			PlayerController mController = col.gameObject.GetComponent<PlayerController>();
			if (Input.GetButtonDown("Fire" + mController.playerSuffix))
			{
				
			}
		}
	}
}
