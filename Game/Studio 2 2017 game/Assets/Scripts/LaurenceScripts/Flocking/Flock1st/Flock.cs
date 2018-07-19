using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flock : MonoBehaviour {

    public float speed = 0.3f;
    float rotationSpeed = 3.0f;
    Vector3 averageHeading;
    Vector3 averagepos;
    float mutualdistance = 4.0f;

    bool turning = false;

	// Use this for initialization
	void Start ()
    {
        //making each wolf have its own speed
        speed = Random.Range(0.5f, 1);
	}

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Vector3.zero) >= GlobalFlock.RoamSize)
        {
            turning = true;
        }
        else
        {
            turning = false;
               
        }

        // if hits the edge of the roam area, then it will rotate back into the area
        if (turning)
        {
            Vector3 direction = Vector3.zero - transform.position;
            transform.rotation = Quaternion.Slerp(transform.rotation,
                                  Quaternion.LookRotation(direction),
                                  rotationSpeed * Time.deltaTime);
            speed = Random.Range(0.5f, 4);
        }
        else
        
        {
            //making sure that x of the time the rules are being applied
            if (Random.Range(0, 2) < 1)
                ApplyRule();
        }

       
        transform.Translate(0, 0, Time.deltaTime * speed);
	}

    void ApplyRule()
    {
        GameObject[] gos;
        gos = GlobalFlock.allFlockers;

        //calc the center of the group
        Vector3 vcentre = Vector3.zero;
        //calc the avoidance of eachother
        Vector3 vavoid = Vector3.zero;
        float gspeed = 0.006f;

        Vector3 endpos = GlobalFlock.endpos;

        float dist;

        int groupsize = 0;
        foreach (GameObject go in gos)
        {
            if (go != this.gameObject)
            {
                dist = Vector3.Distance(go.transform.position, this.transform.position);

                // senses if 2 flockers are close to one another
                if (dist <= mutualdistance)
                {
                    vcentre += go.transform.position;
                    groupsize++;
                    // if in this distance of each other, avoid
                    if (dist < 3.0f)
                    {
                        vavoid = vavoid + (this.transform.position - go.transform.position);
                    }
                    //calc the speed of everyone in the flock
                    Flock moreflock = go.GetComponent<Flock>();
                    gspeed = gspeed + moreflock.speed;
                }
            }
        }

        //if group size more than 0 then calculate center of the group and the average speed of the group
        if (groupsize > 0)
        {
            vcentre = vcentre / groupsize + (endpos - this.transform.position);
            speed = gspeed / groupsize;

            //the direction that the flocker must turn into
            Vector3 direction = (vcentre + vavoid) - transform.position;
            if (direction != Vector3.zero)
            {
                //will make the flocker turn in a different direction if too close to another flocker
                transform.rotation = Quaternion.Slerp(transform.rotation,
                                                       Quaternion.LookRotation(direction),
                                                       rotationSpeed * Time.deltaTime);
            }
        }
    }
}
