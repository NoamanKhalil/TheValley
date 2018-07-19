using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshDeformInput : MonoBehaviour {

    public float force = 10f;
    public float forceOffset = 0.1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetMouseButton(0))
        {
            HandleImput(); 
        }
	}

    void HandleImput()
    {
        // making the main camera shoot our a ray
        Ray inputray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //using physiscs engine to cast the ray and store info on what hit (hitting mesh deformer componet?)
        RaycastHit hit;

        if (Physics.Raycast (inputray, out hit))
        {
            MeshDeformation deformation = hit.collider.GetComponent<MeshDeformation>();
            if (deformation)
            {
                Vector3 point = hit.point;
                //making sure verticies are pushed into the sphere not out
                point += hit.normal * forceOffset;
                deformation.AddDefomationForce(point, force);
              
            }
        }
    }

    
}
