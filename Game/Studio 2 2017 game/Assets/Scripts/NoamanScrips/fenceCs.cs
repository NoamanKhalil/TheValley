using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fenceCs : MonoBehaviour
{

     public int countToDestroy = 2;
	bool candestory;
	public AudioSource aud;
	public ParticleSystem ps;
	public GameManagerCS gm;

	// Use this for initialization
	void Start ()
	{
		aud = GameObject.Find("AxeSwing").GetComponent<AudioSource>();
		gm = GameObject.Find("Gm").GetComponent<GameManagerCS>();
	}
	
	// Update is called once per frame
	void Update ()

	{
		if (candestory == true )
		{
			if (Input.GetMouseButtonDown(0))
			{
				
				countToDestroy--;
				aud.Play();

					gm.PlayerObject.GetComponentInChildren<AttackCs>().playPartiles();
			
				if (countToDestroy <= 0 )
				{
					Destroy(this.gameObject);
				}
			}
		}
	}

	void OnCollisionEnter(Collision col)
	{
		Debug.Log("Col");
		if (col.gameObject.tag == "Axe")
		{
			candestory = true;
		}

	}
}