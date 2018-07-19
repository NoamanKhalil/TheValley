/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class CanvasManager : MonoBehaviour {

	public Text questTitle;
	public Text questText; 
	public Canvas questInfo;
	public Canvas sideBar;
	public Text sideTitle; 
	public Text sideText;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void MissionOneText() 
	{
		questTitle.text = "Find The Missing Engineer";
		questText.text = "Look for clues that indicate the engineer's whereabouts, his Cabin would be a good place to start";
		sideTitle.text = questTitle.text;


	}

	public void MissionTwoText()
	{
		questTitle.text = "Find The Missing Engineer: Part Two"; 
		questText.text = "Follow the path.";
		sideTitle.text = questTitle.text;
		sideText = "Follow the path.";
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
		questTitle.text = "Too Late";
		questText.text = "*journal page explaining what he was doing before he got killed*";
		sideTitle.text = questTitle.text;
		sideText.text = "";


	}
}
*/