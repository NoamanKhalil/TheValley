using UnityEngine;
using System.Collections;
//using UnityStandardAssets.Charicters.FirstPerson;

public class PauseMenu1 : MonoBehaviour {
    //creted by laurence peat
    public Transform canvis;
	public Transform Player;
	public static bool Play;
    

    // Use this for initialization
    void Start () {
       
		Play = true;
        //look = GetComponent<CameraControl>();
       
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			Pause ();

			
	    }
	}

	public void Pause ()
	{
      Play = false;
		
		if (canvis.gameObject.activeInHierarchy == false) 
		{
            CameraControl look = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraControl>();
            look.enabled = false;
            Debug.Log("pause");
			canvis.gameObject.SetActive (true);
			Time.timeScale = 0;
			Cursor.visible = true;
			Screen.lockCursor = false;
           




			
		} 
		else
        {
           
            CameraControl look = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraControl>();
            look.enabled = true;
            Cursor.visible = false;
            Debug.Log("play");
			Screen.lockCursor = true;
			Time.timeScale = 1;
			canvis.gameObject.SetActive (false);
            
			Play = true;

		}
	}
}

// if you want the player to nor be able to move around and look when this happens go 
// into the charicter controller and add a reference to this script