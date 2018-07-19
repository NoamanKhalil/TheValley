using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fogCs : MonoBehaviour
{


	bool fogOn = false;
	public Color clr; 

	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (fogOn)
		{
			RenderSettings.fogDensity += 0.00005f;
		}
	}


	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			//Destroy(this.gameObject);
			fogOn = true;
			RenderSettings.fog = true;
			RenderSettings.fogMode = FogMode.ExponentialSquared;
			RenderSettings.fogColor = clr; 
			RenderSettings.fogDensity = 0.0f;
			Debug.Log("Mili");

		}
 }


}