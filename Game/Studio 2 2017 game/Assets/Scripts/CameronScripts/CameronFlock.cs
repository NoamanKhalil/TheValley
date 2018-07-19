using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameronFlock : MonoBehaviour {


	//public GameObject[] flockers; 
	//public float radius = 5f;
	public CameronFlockManager manager; 
	Rigidbody RB; 
	public Vector3 Direction;
	// Use this for initialization
	void Start () {

		RB = GetComponent <Rigidbody> (); 

		 Direction = new Vector3 ();

		RB.velocity = new Vector3(Random.Range(1,2),0, Random.Range(1,2));
		//flockers = GameObject.FindGameObjectsWithTag ("Cube");
	

		//foreach (GameObject cube in flockers) {
			/*for (int i = 0; i < currentPosition.Length-1; i++) 
			{
				Debug.Log ("running");
				currentPosition [i] = cube.transform.position;
			}
		}*/
		//}
		
	}

	// Update is called once per frame
	void Update () {
		//
		int count = 0; 
		int count2 = 0;
		Vector3 separationVelocity; 
		Vector3 avgPosition;
		Vector3 avgPosition2; 
		Vector3 avgVelocity;
		Vector3 totalVelocity = new Vector3 (0,0,0);
		Vector3 totalPosition = new Vector3 (0, 0, 0); 
		Vector3 totalPosition2 = new Vector3 (0,0,0); 
		foreach (GameObject cube in manager.flockers) {
			//cohesion velocity
			if (Vector3.Distance (this.transform.position, cube.transform.position) < manager.radius && cube != this.gameObject) 
			{
				totalPosition += cube.transform.position;
				count++;

				//totalVelocity += cube.GetComponent<Rigidbody> ().velocity;
			}

			//Separation velocity
			if (Vector3.Distance (this.transform.position, cube.transform.position) < manager.seaparationRadius && cube != this.gameObject)
			{
				Direction.x += cube.transform.position.x - transform.position.x;	
				Direction.z += cube.transform.position.z - transform.position.z; 
				separationVelocity = new Vector3 (Direction.x, 0, Direction.z); 

				count2++;
				Debug.Log ("too close");

			}

			//Alignment velocity

		
		}

			if (count > 0) 
			{

				//avgVelocity = totalVelocity / count; 
				avgPosition = totalPosition / count;

			}

	
			//Direction.x;
			//Direction.z;
			avgPosition2 = totalPosition2 /= count2; 
			avgPosition2 = Direction;



	
		//RB.velocity = avgVelocity;

		transform.position = transform.position + totalVelocity * Time.deltaTime;
		Debug.DrawLine (transform.position, avgPosition2, Color.red); 

	}
}
