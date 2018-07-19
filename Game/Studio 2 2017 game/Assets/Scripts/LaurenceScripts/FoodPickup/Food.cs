using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour {

    public float Distance;
    public GameObject[] ediles;
    public GameObject Player;
    public PlayerStatCs PS;

	// Use this for initialization
	void Start ()
    {
        ediles = GameObject.FindGameObjectsWithTag("Food");
	}
	
	// Update is called once per frame
	void Update ()
    {
      

        foreach (GameObject foodobj in ediles)
        {
            Distance = Vector3.Distance(Player.transform.position, foodobj.transform.position);
            if (Distance > 2f)
            {
                PS.healthIncrease();
                Destroy(foodobj);
            }
        }
		
	}
}
