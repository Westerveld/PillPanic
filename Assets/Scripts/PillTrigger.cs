using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;


public class PillTrigger : MonoBehaviour
{

	public PillType myPill;

	public GameObject[] pills;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		

	}

	void OnTriggerStay(Collider col)
	{
		if (col.gameObject.CompareTag( "Player"))
		{
			PlayerController mController = col.gameObject.GetComponent<PlayerController>();
			if (mController.buttonPressed)
			{
				mController.inventory.AddToInventory(myPill);
			}
		}
	}
}
