using UnityEngine;
using System.Collections;

public class CameraRotate : MonoBehaviour
{

    public GameObject rotationpoint;

    void Start()
    {
        Time.timeScale = 1;
		
    }
	
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(new Vector3(0, -1f, 0) * 10.0f * Time.deltaTime); 
	
    }
}
