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
                Instantiate(pills[Random.Range(0, pills.Length)], transform.position + new Vector3(0.0f, 5.0f, 0.0f), Quaternion.identity);
			}
		}
	}
}
