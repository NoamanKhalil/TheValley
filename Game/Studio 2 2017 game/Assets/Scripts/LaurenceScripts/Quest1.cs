using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest1 : MonoBehaviour {
    //creted by laurence peat
    public GameObject Questmenu;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public  void closequest()
    {
        Questmenu.active = false;
        Cursor.visible = false;
        Screen.lockCursor = true;
        Time.timeScale = 1;
    }
}
