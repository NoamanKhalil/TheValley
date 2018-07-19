using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceCheck : MonoBehaviour {


void OnCollisionEnter(Collision col)
{
	if (col.gameObject.tag == "Fence" )
	{
		if (Input.GetMouseButton(0))
		{
			Destroy(col.gameObject);
		}
	}

	}
}
