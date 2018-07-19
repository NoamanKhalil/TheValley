using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getBowCs : MonoBehaviour {

    public int distToBow;

	public GameManagerCS gm;

	public GameObject UI;
    bool canPickUp;
	// Use this for initialization
	void Start()
	{
		//UI.SetActive(false);
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.E) && canPickUp)
		{
			gm.axeObject.SetActive(false);
			gm.bowObject.SetActive(true);
			UI.SetActive(false);
            this.gameObject.SetActive(false);
		}
	}


	void OnTriggerEnter(Collider other)
	{
		UI.SetActive(true);
		canPickUp = true;
	}

    void OnTriggerExit(Collider other)
	{
		UI.SetActive(false);
		canPickUp = false;
	}
}
