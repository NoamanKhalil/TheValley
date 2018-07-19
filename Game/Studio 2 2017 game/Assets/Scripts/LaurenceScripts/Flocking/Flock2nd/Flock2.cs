using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flock2 : MonoBehaviour
{

    Rigidbody RB;


    public GameObject center;

    public Flock2Manager MAN;

   

    // Use this for initialization
    void Start()
    {
        RB = GetComponent<Rigidbody>();

        RB.velocity = new Vector3(Random.Range(1, 2), 0, Random.Range(1, 2));

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 totalposition = Vector3.zero;
        Vector3 totalposition2 = Vector3.zero;
        Vector3 averagepos;
        Vector3 averagepos2;
        Vector3 averagevelocity;
        Vector3 totalvelocity = Vector3.zero;
        

        int count = 0;
        int count2 = 0;

        Vector3 Direcrtion = new Vector3();
 
        foreach (GameObject cube in MAN.flockers)
        {
            //coheshan
            if (Vector3.Distance(this.transform.position, cube.transform.position) < MAN.radius && cube != this.gameObject) 
                {
                   totalposition += cube.transform.position;
                   count++;
                 totalvelocity += cube.GetComponent<Rigidbody>().velocity;
                totalvelocity = cube.transform.position * MAN.speed * Time.deltaTime * Direcrtion.x;
                }
            //seperation
           if (Vector3.Distance(this.transform.position, cube.transform.position) < MAN.minradius && cube != this.gameObject)
            {
                Direcrtion.x += cube.transform.position.x - transform.position.x;
                Direcrtion.z += cube.transform.position.z - transform.position.z;

                totalposition2 += cube.transform.position;
                count2++;
            }
           

       
        }

         if (count > 0)
        {


           averagepos = totalposition / count;
           averagevelocity = totalvelocity / count;
        }



        averagepos2 = totalposition2 /= count2;

       
       // RB.velocity = averagevelocity;

        //averagevelocity.Normalize();

        transform.position =(transform.position + totalvelocity * Time.deltaTime);
        //transform.position = Vector3.MoveTowards(transform.position, averagepos2, Time.deltaTime * MAN.speed);

        //transform.Translate(0, 0, Time.deltaTime * MAN.speed);

        


    }

    
}
