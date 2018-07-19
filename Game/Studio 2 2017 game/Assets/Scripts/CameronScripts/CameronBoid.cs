using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameronBoid : MonoBehaviour {

	public Vector3 finalVelocity; 
	public CameronFlockManager manageflock; 
	// Use this for initialization
	void Start () {

		finalVelocity = new Vector3(Random.Range(1,30),0,Random.Range(1,30)); 
		
	}
	

	void Update () {
		//Alignment velocity
		//-----------------------------------------------------------------------------------------------------------------------------------
		Vector3 alignmentVelocity = Vector3.zero;
		Vector3 totalVelocity = Vector3.zero;  
		int count = 0; 

		foreach (GameObject cube in manageflock.flockers) 
		{
			if (Vector3.Distance (transform.position, cube.transform.position) < manageflock.radius && cube != this.gameObject) 
			{

				totalVelocity += cube.GetComponent<CameronBoid> ().finalVelocity; 
				count++; 
			}

		}

		if (count > 0) {
			
			alignmentVelocity = totalVelocity / count; 
			//finalVelocity = alignmentVelocity;
		}
		//------------------------------------------------------------------------------------------------------------------------------------
		//Cohesion Velocity
		//------------------------------------------------------------------------------------------------------------------------------------
		Vector3 cohesionVelocity = Vector3.zero;
		Vector3 totalPosition = Vector3.zero;
		Vector3 avgPosition; 
		int cohesionCount = 0; 

		foreach (GameObject cube in manageflock.flockers) 
		{
			if (Vector3.Distance (transform.position, cube.transform.position) < manageflock.radius && cube != this.gameObject) 
			{
				totalPosition += cube.transform.position; 
				cohesionCount ++; 
			}
		}
		if (cohesionCount > 0) 
		{
			avgPosition = totalPosition / cohesionCount; 
			cohesionVelocity = avgPosition - transform.position;
			//finalVelocity += cohesionVelocity;
		}
		//-------------------------------------------------------------------------------------------------------------------------------------
		//Separation Velocity
		//-------------------------------------------------------------------------------------------------------------------------------------
		Vector3 separationVelocity = Vector3.zero; 
		Vector3 separationDistance = Vector3.zero; 
		int separationCount = 0;

		foreach (GameObject cube in manageflock.flockers) 
		{
			if (Vector3.Distance (transform.position, cube.transform.position) < manageflock.seaparationRadius && cube != this.gameObject)
			{
				separationDistance.x += this.transform.position.x - cube.transform.position.x; 
				separationDistance.z += this.transform.position.z - cube.transform.position.z;
				separationCount++;
			}
		}

		if (separationCount > 0) {
			
			separationVelocity = separationDistance/separationCount;
		}
			//finalVelocity += separationVelocity;

		//--------------------------------------------------------------------------------------------------------------------------------------
		finalVelocity = alignmentVelocity * manageflock.alignmentFactor +cohesionVelocity * manageflock.cohesionFactor + separationVelocity * manageflock.separationFactor;
		finalVelocity = Vector3.ClampMagnitude(finalVelocity,3f);
		transform.position += finalVelocity * Time.deltaTime; 
		//--------------------------------------------------------------------------------------------------------------------------------------
		//Look in Direction
		//--------------------------------------------------------------------------------------------------------------------------------------


		Debug.DrawLine (transform.position, transform.position+finalVelocity);
		transform.LookAt (finalVelocity);
	}
}
