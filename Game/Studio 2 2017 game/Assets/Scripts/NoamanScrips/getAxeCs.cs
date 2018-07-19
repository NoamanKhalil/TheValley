using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getAxeCs : MonoBehaviour
{

	public int distToAxe;

	public GameManagerCS gm;

	public GameObject UI;
	bool canPickUp;
	// Use this for initialization
	void Start()
	{
		UI.SetActive(false);
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.E) &&canPickUp)
		{
			gm.getAxe();
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