using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boid : MonoBehaviour {

    //creted by laurence peat

    Vector3 finalVelocity;
    public Flock2Manager man;
    
    Vector3 look;

	// Use this for initialization
	void Start ()
    {
        
        finalVelocity = new Vector3(Random.Range(0,40f),0,Random.Range(0,-10f));

	}
	
	// Update is called once per frame
	void Update ()
    {

        //alignment velocity
        // ----------------------------------------------------------------------------------------------------------------------
        Vector3 alignmentVel;

        Vector3 totalVel = Vector3.zero;
        

        int count = 0;
        

        foreach (GameObject cube in man.flockers)
        {

            
            if(Vector3.Distance(this.transform.position, cube.transform.position) <  man.radius)
            {
           
                totalVel = cube.GetComponent<Boid>().finalVelocity + totalVel;
                
                count++;

            }
            
         
        }

        alignmentVel = totalVel / count;
        //cohesan velocity
        // ----------------------------------------------------------------------------------------------------------------------

        Vector3 totalPos = Vector3.zero;
        Vector3 averagePos;
        Vector3 coVel;

        count = 0;

        foreach (GameObject cube in man.flockers)
        {

            if (Vector3.Distance(this.transform.position, cube.transform.position) < man.radius)
            {
                totalPos =  cube.transform.position + totalPos;

                count++;

            }

             
        }

            averagePos = totalPos / count;
        coVel = averagePos - this.transform.position;

        //Seperation velocity dist cube and the tranform 
        // ----------------------------------------------------------------------------------------------------------------------

            Vector3 seperate;
            Vector3 direnceion = new Vector3();


            count =0;

        foreach (GameObject cube in man.flockers)
        {

            if (Vector3.Distance(this.transform.position, cube.transform.position) < man.minradius)
            {

                direnceion.x += this.transform.position.x - cube.transform.position.x;
                direnceion.z += this.transform.position.z - cube.transform.position.z;

                count++;
 
            }
              

        }

        seperate = direnceion / count;


        //-----------------------------------------------------------------------------------------------------------------------


        finalVelocity = man.alignmentEditor*alignmentVel + man.coheasanEditor*coVel + man.seperationEditor*seperate;
        finalVelocity = Vector3.ClampMagnitude(finalVelocity, 10f);

        
        transform.position += finalVelocity * Time.deltaTime;

        

        transform.LookAt(look);
		
	}
}
