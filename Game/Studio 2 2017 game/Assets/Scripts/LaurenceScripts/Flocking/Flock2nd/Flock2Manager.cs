using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flock2Manager : MonoBehaviour {

    public float radius = 7;
    public float minradius = 4;

    public float alignmentEditor = 1;
    public float coheasanEditor = 1;
    public float seperationEditor = 1;
    public float collisionaviodeditor = 1;

    public float speed = 0.5f;

    public LayerMask wolf;
    
    public GameObject[] flockers;
   // public GameObject[] Collisions;

    // Use this for initialization
    void Start ()
    {

        //flockers =  GameObject.FindGameObjectsWithTag("Cubes");
        flockers = new GameObject[transform.childCount];
        for (int i = 0; i <transform.childCount; i++)
        {
            flockers[i] = transform.GetChild(i).gameObject;
        }
        //Collisions = GameObject.FindGameObjectsWithTag("Avoid");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
