using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCs : MonoBehaviour

{

	//public GameManagerCS Gm ; 
	public GameManagerCS Gm;

	//public CameronGameManager Gm;
	public float minimumDistCheck ;


	private Animator doorAnimation;
	private bool isDoorOpen;

	// Use this for initialization
	void Start ()
	{
		doorAnimation= GetComponent<Animator>(); 
		isDoorOpen = false ; 
		doorAnimation.SetInteger ("DoorState",1);
	}

	// 0 will be basic state  (door closed )
	//1 will be open door 

	// Update is called once per frame
	void Update ()
	{
		if ( Input.GetKeyUp (KeyCode.E)  &&Gm.comparePlayerPos (this.gameObject , minimumDistCheck))
     	{
			Debug.Log ("Animation works "); 
			Debug.Log (doorAnimation.GetCurrentAnimatorStateInfo(0).normalizedTime);
			if (doorAnimation.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.1f &&isDoorOpen.Equals (false))
			{
				Debug.Log ("Animation clip is playing"); 
				doorAnimation.SetInteger ("DoorState",0);
				isDoorOpen = true;
			}
			else if(doorAnimation.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.1f&&isDoorOpen.Equals(true))
			{
				doorAnimation.SetInteger ("DoorState",1);
			    isDoorOpen = false;
			}
		}

	}
}
