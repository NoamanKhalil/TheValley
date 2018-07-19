using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOG : MonoBehaviour
{

    public float min;
    public float max;
    public float time;

    // Use this for initialization
    void Start()
    {
		
    }
	
    // Update is called once per frame
    void Update()
    {
        RenderSettings.fogDensity = Mathf.Lerp(min, max, time);
            
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);

            RenderSettings.fog = true;
            Debug.Log("Mili"); 

        }
    }
}
