using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAxe : MonoBehaviour {


	public CameronGameManager manager; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player" && manager.mission2 == true && manager.axeFound == false) 
		{

			Debug.Log ("triggered");

			manager.questInfo.enabled = true; 
			manager.FoundAxe (); 
			manager.canHaveAxe = true;
			
		}
	}
}
