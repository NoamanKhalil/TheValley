using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeAxeCs : MonoBehaviour {


	public GameManagerCS gm;
	public GameObject axe; 
    public float distToTree ;
	// Use this for initialization
	void Start () 
	{
		gm= GetComponent <GameManagerCS>(); 
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey(KeyCode.E) && gm.comparePlayerPos(gm.PlayerObject, distToTree) )
		{

			gm.getAxe();
			axe.SetActive(false);
		}
	}
}
