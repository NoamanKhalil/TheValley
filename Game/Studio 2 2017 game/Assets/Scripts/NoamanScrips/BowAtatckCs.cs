using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class BowAtatckCs : MonoBehaviour {

	public GameObject firePoint ;
	public GameObject Arrow; 

	public float power; 
	public float forceMutiplyer;
	public float timeToNextShot ;
	public int noOfArrows;

	public Text ArrowDisplay;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown (0))
		{
			
		}

		ArrowDisplay.text ="Arrows:"+ noOfArrows;
		Vector3 forward = firePoint.transform.TransformDirection(Vector3.forward) * 10;
		Debug.DrawRay(transform.position, forward, Color.green);	

		timeToNextShot -=Time.deltaTime ;

		if (Input.GetMouseButtonUp (0)&& timeToNextShot <=0 && noOfArrows >=1)
		{
			GameObject newArrow = Instantiate(Arrow,firePoint.transform.position,firePoint.transform.rotation )as GameObject ;
			Rigidbody rb = newArrow.GetComponentInChildren<Rigidbody>(); 
			rb.velocity = forward * forceMutiplyer;
			noOfArrows--;
			timeToNextShot =0.5f ;
		}
	}
}
