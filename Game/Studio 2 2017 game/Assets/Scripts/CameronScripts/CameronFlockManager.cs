using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameronFlockManager : MonoBehaviour {

	public GameObject[] flockers; 
	public float radius = 25f;
	public float seaparationRadius = 7f;
	public float separationFactor;
	public float cohesionFactor; 
	public float alignmentFactor; 
	// Use this for initialization
	void Start () {

		flockers = GameObject.FindGameObjectsWithTag ("Cube");

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
