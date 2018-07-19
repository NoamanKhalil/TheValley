using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoidOptimized : MonoBehaviour {

    //creted by laurence peat
    Vector3 finalVelocity;
    public  Flock2Manager man;
   

    // Use this for initialization
    void Start()
    {

		finalVelocity = new Vector3 (Random.Range (0, 40f), 0, Random.RandomRange (0, -10f));
    }

    // Update is called once per frame
    void Update ()
    {
        Vector3 alignmentVel;
        Vector3 totalVel = Vector3.zero;

        Vector3 totalPos = Vector3.zero;
        Vector3 averagePos;
        Vector3 coVel;

        Vector3 seperate;
        Vector3 direnceion = new Vector3();

        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        Vector3 left = transform.TransformDirection(Vector3.left);
        Vector3 right = transform.TransformDirection(Vector3.right);
        RaycastHit hit;

        Vector3 avoid;
        Vector3 ColDiretion = new Vector3();

        int count = 0;
        
        int count3 = 0;


        foreach (GameObject cube in man.flockers)
        {


            if (Vector3.Distance(this.transform.position, cube.transform.position) < man.radius)
            {
                
                totalVel = cube.GetComponent<BoidOptimized>().finalVelocity + totalVel;
                totalPos = cube.transform.position + totalPos;

                count++;
               

            }
            if (Vector3.Distance(this.transform.position, cube.transform.position) < man.minradius)
            {

                direnceion.x += this.transform.position.x - cube.transform.position.x;
                direnceion.z += this.transform.position.z - cube.transform.position.z;

                count3++;

            }
            
           

            //foreach (GameObject colliders in man.Collisions)
            //{
            //    if (Vector3.Distance(this.transform.position, colliders.transform.position) >= man.collisionaviodeditor)
            //    {
            //        ColDiretion.x -= this.transform.position.x - colliders.transform.position.x;
            //        ColDiretion.z -= this.transform.position.z - colliders.transform.position.z;
            //    }
            //}



        }
        Debug.DrawLine(transform.position, transform.position + fwd.normalized * 7, Color.red);

        if (Physics.Raycast(transform.position, fwd, out hit, 7f, man.wolf, QueryTriggerInteraction.Ignore) ||
            Physics.Raycast(transform.position, left, out hit, 7f, man.wolf, QueryTriggerInteraction.Ignore) ||
            Physics.Raycast(transform.position, right, out hit, 7f, man.wolf, QueryTriggerInteraction.Ignore))
        {


            // Debug.DrawRay(cube.transform.position, fwd, out hit, 5f);
            ColDiretion = hit.point - hit.transform.position ;
            ColDiretion.y = 0;
//            Debug.Log(hit.transform.name);
           // Debug.Log(hit.transform.name);
        }
        if (count == 0 )
        {
            return;
        }
       
        averagePos = totalPos / count;
        coVel = averagePos - this.transform.position;

        avoid = ColDiretion;

        seperate = direnceion / count3;


        alignmentVel = totalVel / count;

        finalVelocity = man.alignmentEditor * alignmentVel + man.coheasanEditor * coVel + man.seperationEditor * seperate + avoid * man.collisionaviodeditor;
        
       




       
        finalVelocity = Vector3.ClampMagnitude(finalVelocity, 10f);
        finalVelocity.y = 0;

        //transform.position += finalVelocity * Time.deltaTime * man.speed;
        Rigidbody rg= this.GetComponent<Rigidbody>();
        rg.AddForce(finalVelocity * man.speed );

        rg.velocity = Vector3.ClampMagnitude(rg.velocity, 0.3f);
       

        transform.rotation = Quaternion.Lerp(transform.rotation , Quaternion.LookRotation(finalVelocity),0.3f);
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0, 0.1f);
        Gizmos.DrawSphere(transform.position, 5);
    }
}
