using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalFlock : MonoBehaviour {

    public GameObject Flockers;
    public static int RoamSize = 10;

    static int FlockNum = 6;
    public static GameObject[] allFlockers = new GameObject[FlockNum];

    public static Vector3 endpos = Vector3.zero;


	// Use this for initialization
	void Start ()
    {
        for (int i = 0; i < FlockNum; i++)
        {
            Vector3 pos = new Vector3(Random.Range(-RoamSize, RoamSize),
                                      // Random.Range(-RoamSize, RoamSize),
                                      Random.Range(-0, 0),
                                      Random.Range(-RoamSize, RoamSize));
            allFlockers[i] = (GameObject)Instantiate(Flockers, pos, Quaternion.identity);
        }
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Random.Range(0,10000000) < 50)
        {
            endpos = new Vector3(Random.Range(-RoamSize, RoamSize),
                                       // Random.Range(-RoamSize, RoamSize),
                                        Random.Range(-0, 0),
                                       Random.Range(-RoamSize, RoamSize));
        }
	}
}
