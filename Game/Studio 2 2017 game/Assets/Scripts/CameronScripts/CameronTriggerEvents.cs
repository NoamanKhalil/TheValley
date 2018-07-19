using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameronTriggerEvents : MonoBehaviour {


	public CameronGameManager manager; 
	public GameObject player; 
	// Use this for initialization
	void Start () {
		
		manager = GameObject.Find ("GameManager").GetComponent<CameronGameManager>(); 

		
	}
	
	// Update is called once per frame
	void Update () {

		if (Vector3.Distance (player.transform.position, this.transform.position) < 3f && manager.bodyFound == false) 
		{
			manager.questInfo.enabled = true;
			manager.MissionThreeText ();
		}
			
		
	}
}
