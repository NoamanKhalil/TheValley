using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <Game Manager author>
/// Created by by Noaman khalil  created on june 11 2017 @ 1.18 pm 
/// </summary>

public class GameManagerCS : MonoBehaviour 
{
	public GameObject bowObject;
	public GameObject axeObject;
	public GameObject PlayerObject ;
	public Text missionText;
	public bool playerAlive;

	bool hasBow ; 
	bool hasAxe;
	bool isBowActive;
	bool isAxeActive;

	// Use this for initialization
	void Start ()
	{
		//if (axeObject !=null)
		//{
		//	axeObject.SetActive(false);
		//}
		hasAxe = false;
		hasBow = false;
	}

	// Update is called once per frame
	void Update ()
	{
		SwitchWeapons();
	}
	public void getAxe()
	{
		axeObject.SetActive(true);
		hasAxe = true;
	}
	public void getBow()
	{
		bowObject.SetActive(true);
		hasBow = true;
	}
	public bool comparePlayerPos (GameObject compareObject , float distToCheck)
	{
		//||PlayerObject.transform.position.y < compareObject.transform.position.y
		if ( Vector3.Distance(PlayerObject.transform.position, compareObject.transform.position) <= distToCheck )
		{
			return true ; 
		}
		else 
		{
			return false; 
		}


	}

	public void SwitchWeapons()
	{

		if (hasAxe ==true && hasBow==true)
		{
			if (Input.GetKey(KeyCode.Alpha1) && bowObject.activeInHierarchy == true)
			{

				bowObject.SetActive(false);
				axeObject.SetActive(true);
				//isAxeActive = true;
				return;

			}
			else if (Input.GetKey(KeyCode.Alpha2) && axeObject.activeInHierarchy == true)
			{
				axeObject.SetActive(false);
				bowObject.SetActive(true);
				//isBowActive = true;
				return;
			}
		}
	}
}
