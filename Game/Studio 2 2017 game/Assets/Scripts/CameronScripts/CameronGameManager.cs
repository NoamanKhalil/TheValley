using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; 
using UnityEngine;

public class CameronGameManager : MonoBehaviour {

	public GameObject bowObject;
	public GameObject axeObject;
	public GameObject PlayerObject ;
	public GameObject Wolf;
	public GameObject TreeAxe;


	public Canvas questInfo;
	public Canvas sideBar;
	public Canvas questMenu; 

	public Text questButton1;
	public Text questButton2; 
	public Text questButton3; 
	public Text questButton4;
	public Text questTitle;
	public Text questTitle1;
	public Text questTitle2;
	public Text questTitle3; 
	public Text questTitle4;
	public Text questText; 
	public Text sideTitle; 
	public Text sideText;

	public bool playerAlive;
	public bool mission1; 
	public bool mission2; 
	public bool mission3; 
	bool hasBow ; 
	bool hasAxe;
	public bool axeFound;
	public bool canHaveAxe;
	public bool canHaveBow; 
	public bool bodyFound; 



	void Awake()

	{
		bodyFound = false;
		axeFound = false;
		canHaveAxe = false; 
		canHaveBow = false; 
		hasAxe = false;
		hasBow = false;
		axeObject.SetActive(false);
		mission1 = false;
		mission2 = false;
		mission3 = false;

	
	}

	// Use this for initialization
	void Start ()
	{
		Wolf.gameObject.SetActive (false);
		questInfo.enabled = true;
		MissionOneText ();
		questMenu.enabled = false;

		questTitle1.text = "Find The Missing Engineer"; 
		questTitle2.text = "Find The Missing Engineer: Part Two";
		questTitle3.text = "Too Late";


	}

	// Update is called once per frame
	void Update ()
	{
		

		if (canHaveAxe == true) {
			if (Input.GetKey ("1") && axeObject.activeInHierarchy.Equals (false) && hasAxe == false) {

				
				if (bowObject.activeInHierarchy.Equals (true)) {
					bowObject.SetActive (false);
					hasBow = false;
				}
				axeObject.SetActive (true);
				hasAxe = true;
			
			}
			if (Input.GetKey ("2") && bowObject.activeInHierarchy.Equals (false) && hasBow == false) {
				Debug.Log ("2 is working ");

				if (axeObject.activeInHierarchy.Equals (true)) {
					axeObject.SetActive (false);
					hasAxe = false;
				}

				bowObject.SetActive (true);

			}
		}

		if (questInfo.enabled == true && mission1 == false)
		{
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				questInfo.enabled = false;
				mission1 = true;
			}
		}

		if (questInfo.enabled == true && mission1 == true && mission2 == false)
		{
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				questInfo.enabled = false;
				mission2 = true;
			}
		}

		if (questInfo.enabled == true && axeFound == true) 
		{
			if (Input.GetKeyDown (KeyCode.Escape)) 
			{
				questInfo.enabled = false; 
				TreeAxe.GetComponent<MeshRenderer> ().enabled = false;
			}
		}

		if (questInfo.enabled == true && bodyFound == true) 
		{
			mission3 = true;

			if (Input.GetKeyDown(KeyCode.Escape))
			{

				questInfo.enabled = false;
			}
		}

		if (mission3 == true) 
		{
			Debug.Log ("m3 is on");
			Wolf.gameObject.SetActive (true);
		}

		if (Input.GetKeyDown (KeyCode.J)) 
		{
			questMenu.enabled = true;
		}


	}
	public void getAxe()
	{
		axeObject.SetActive(true);
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



	public void MissionOneText() 
	{
		questTitle.text = questTitle1.text;
		questText.text = "Look for clues that indicate the engineer's whereabouts, his Cabin would be a good place to start";
		sideTitle.text = questTitle.text;


	}

	public void MissionTwoText()
	{
		questTitle.text = questTitle2.text;
		questText.text = "Follow the path.";
		sideTitle.text = questTitle.text;
		sideText.text = "Follow the path.";
	}

	public void FoundAxe () 
	{
		axeFound = true;
		questTitle.text = "";
		questText.text = " 'There's an axe wedged in that tree, I could use this to cut down the trees blocking the path.'";



	}

	public void MissionThreeText()
	{
		bodyFound = true;
		questTitle.text = questTitle3.text;
		questText.text = "*journal page explaining what he was doing before he got killed*";
		sideTitle.text = questTitle.text;
		sideText.text = "";


	}

	public void QuestMenu()
	{
		questMenu.enabled = true; 

		if (mission1 == true) 
		{
			questButton1.text = questTitle1.text;
		}

		if (mission2 == true) 
		{
			questButton2.text = questTitle2.text;

		}

		if (mission3 == true)
		{
			questButton3.text = questTitle3.text; 
		}

		
	}
}
