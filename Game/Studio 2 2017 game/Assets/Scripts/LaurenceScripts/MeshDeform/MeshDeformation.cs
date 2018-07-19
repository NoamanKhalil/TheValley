using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent (typeof(MeshFilter))]

public class MeshDeformation : MonoBehaviour {

    Mesh defomingMesh;
    Vector3[] originalVerticies, displacedVerticies;

    Vector3[] vertexVelocities;
    public float springForce = 20f;
    public float damping = 5f;
    float uniformscale = 1f;


    // Use this for initialization
    void Start ()
       
    {
        //original verticies being made into displaced verticies
        defomingMesh = GetComponent<MeshFilter>().mesh;
        originalVerticies = defomingMesh.vertices;
        displacedVerticies = new Vector3[originalVerticies.Length];
        for (int i = 0; i < originalVerticies.Length; i++)
        {
            displacedVerticies[i] = originalVerticies[i];
          
        }
        vertexVelocities = new Vector3[originalVerticies.Length];
        //vertices move as mesh is deformed, storing velocity of each vertex
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        uniformscale = transform.localScale.x;
		for (int i = 0; i < displacedVerticies.Length; i++)
        {
            UpDateVertex(i);
        }
        defomingMesh.vertices = displacedVerticies;
        defomingMesh.RecalculateNormals();
       
    }
    //aading a debug draw line from camera to where the deformer is
    public void AddDefomationForce(Vector3 point, float force)
    {
        Debug.DrawLine(Camera.main.transform.position, point);
        point = transform.InverseTransformPoint(point);
        //making sure that this is looping through all displaces verticies and to apply force
        for (int i = 0; i <displacedVerticies.Length; i++)
        {
            addforcetovertex(i, point, force);
        }
     
    }

    void addforcetovertex(int i, Vector3 pont, float force)
    {
        //direction and distance of deform force derived from vector that points from force pont to vertext pos
        Vector3 pontToVertex = displacedVerticies[i] - pont;
        pontToVertex *= uniformscale;
        //using inverse-square law --- original force/distance squared +1f (so force is at full strength)(so it wont shoot to infinity)
        float attenuantedForce = force / (1f + pontToVertex.sqrMagnitude);
        //acceleration being calculated via a = F/m
        float velocity = attenuantedForce * Time.deltaTime;
        vertexVelocities[i] += pontToVertex.normalized * velocity;
      
    }

    void UpDateVertex (int i)
    {
        // adding a spring method to the deformed pesition 
        Vector3 velocity = vertexVelocities[i];
        Vector3 displacement = displacedVerticies[i] - originalVerticies[i];
        displacement *= uniformscale;
        velocity -= displacement * springForce * Time.deltaTime;
        velocity *= 1f - damping * Time.deltaTime;
        vertexVelocities[i] = velocity;
        displacedVerticies[i] += velocity * (Time.deltaTime / uniformscale);
       
    }
}
