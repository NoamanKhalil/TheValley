using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameronNewBoid : MonoBehaviour {
	public Vector3 finalVelocity;
	public CameronFlockManager manageFlocking; 

	// Use this for initialization
	void Start () {

		finalVelocity = new Vector3 (Random.Range(1f,20f),0,Random.Range(1f,20f));
	}
	
	// Update is called once per frame
	void Update () {


		Vector3 alignmentVelocity = Vector3.zero; 
		Vector3 cohesionVelocity = Vector3.zero; 
		Vector3 separationVelocity = Vector3.zero;
		Vector3 totalVelocity = Vector3.zero; 
		Vector3 totalPosition = Vector3.zero; 
		Vector3 avgPosition = Vector3.zero; 
		Vector3 separationDistance = Vector3.zero; 
		int count = 0; 
		int separationCount = 0; 

		foreach (GameObject cube in manageFlocking.flockers)
		{

			//Cohesion and alignment
			//------------------------------------------------------------------------------------------------------
			if ( Vector3.Distance (transform.position, cube.transform.position) < manageFlocking.radius )
			{
				totalVelocity += cube.GetComponent<CameronNewBoid>().finalVelocity;
				totalPosition += cube.transform.position; 
				count ++; 

			}
			//-------------------------------------------------------------------------------------------------------
			//Separation
			//-------------------------------------------------------------------------------------------------------
			if (Vector3.Distance ( transform.position, cube.transform.position) < manageFlocking.seaparationRadius)
			{
				separationDistance.x += this.transform.position.x - cube.transform.position.x;
				separationDistance.z += this.transform.position.z - cube.transform.position.z; 
				separationCount ++; 
				
			}
			//-------------------------------------------------------------------------------------------------------
		}
		//-----------------------------------------------------------------------------------------------------------

		if (count > 0)
		{
			avgPosition = totalPosition / count; 
			alignmentVelocity = totalVelocity / count;
			cohesionVelocity = avgPosition - transform.position; 
		}

		if (separationCount  > 0 ) 
		{
			separationVelocity = separationDistance/separationCount;
		}

		finalVelocity = alignmentVelocity * manageFlocking.alignmentFactor + cohesionVelocity * manageFlocking.cohesionFactor + separationVelocity * manageFlocking.separationFactor;
		finalVelocity = Vector3.ClampMagnitude (finalVelocity, 3f);
		transform.position += finalVelocity * Time.deltaTime;

		Debug.DrawLine (transform.position, transform.position + finalVelocity);
		transform.LookAt (transform.position + finalVelocity);

	}
}
