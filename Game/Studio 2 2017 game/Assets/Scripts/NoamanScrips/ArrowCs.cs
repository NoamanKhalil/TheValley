using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowCs : MonoBehaviour {

	Rigidbody rb ;

	// Use this for initialization
	void Start ()
	{
		rb=GetComponentInChildren<Rigidbody>();	
		//GetComponentInChildren<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll ;
	}
	
	// Update is called once per frame
	void Update ()
	{
		//takes velcity and converts to rotation 
		transform.rotation = Quaternion.LookRotation(rb.velocity) ;
		Destroy(this.gameObject, 5.0f);
	}


	void OnCollisionEnter(Collision other )
	{
//		//other here being the target
		//Debug.Log (other.gameObject);
		transform.parent = other.gameObject.transform;
		GetComponentInChildren<Collider>().enabled = false ;
		GetComponentInChildren<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll ;
		ArrowCs.Destroy(this.gameObject);
	}
}
