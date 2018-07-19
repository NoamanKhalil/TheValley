using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpcontrollerCs : MonoBehaviour
{
	public GameObject camera;
	public GameObject wolf;
	public AudioSource walking;
	public float inputDelay;
	public float rotationSpeed;
	public float Xaxis, YAxis ;

	public float straffeVel;
	public float runVel = 36f;
	public float jumpVel = 0.2f;

	private float forwardVel;
	private Vector3 velocity;
	private Vector3 IVeloctiy;
	private float walkVel = 8f;
	Rigidbody rb;
	float forwardInput, straffeInput;
	private PlayerStatCs stat;
	private float tempStamina;
	bool isPlaying;
	bool canJump;

	void Start()
	{
		stat = GetComponent<PlayerStatCs>();
		rb = GetComponent<Rigidbody>();
		forwardInput = straffeInput = 0;
		isPlaying = false;
		wolf = null;

		//Cursor.lockState = CursorLockMode.Locked;
		//Cursor.visible = false;

		forwardVel = walkVel;
	}

	void Update()
	{
		stat.getStamina(tempStamina);
		Run();

		forwardInput = Input.GetAxis("Vertical") * forwardVel;
		straffeInput = Input.GetAxis("Horizontal") * forwardVel;
//		Debug.Log(straffeInput);
		//transform.Translate(straffeInput, 0, forwardInput);
		velocity = new Vector3(straffeInput, 0, forwardInput);
		//velocity = transform.localToWorldMatrix * velocity ;
		velocity = transform.TransformDirection(velocity);
		velocity.y = rb.velocity.y; 

		// code to play audio /pasue it 
		if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
		{
			walking.Play();
		}
		if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
		{
			walking.Pause();
		}
		//if (Mathf.Abs(forwardInput) > inputDelay)
		//{
			//rb.velocity = new Vector3(0.0f, 0.0f, forwardInput);
			//rb.velocity = transform.forward * forwardInput * forwardVel;
			//take into account the forward of the camera 
			rb.velocity =  velocity;
			//rb.velocity = direction; 


		//}
		//Jump code
		if (canJump & Input.GetKeyUp(KeyCode.Space))
		{
			//rb.velocity += transform.up* jumpVel;
			//rb.velocity =new Vector3(0, jumpVel, 0);
			rb.AddForce(new Vector3(0, jumpVel, 0), ForceMode.Impulse);
			canJump = false;
		}

	}


	//void CameraRotate()
	//{
	//		 Xaxis = Input.GetAxis("Mouse X") * rotationSpeed;
	//YAxis -= Input.GetAxis("Mouse Y") * rotationSpeed;
	//YAxis = Mathf.Clamp(YAxis, -20, 60);

	//		transform.Rotate(0, Xaxis, 0);
	//		camera.transform.localEulerAngles = new Vector3(YAxis, 0, 0); 
	//	}



	//void FixedUpdate()
	//{

		//if (Mathf.Abs(forwardInput) > inputDelay)
		//{
		//	//rb.velocity = new Vector3(0.0f, 0.0f, forwardInput);
		//	//rb.velocity = transform.forward * forwardInput * forwardVel;
		//	rb.velocity = direction;


		//}
		//if (Mathf.Abs(straffeInput) > inputDelay)
		//{
		//	//rb.velocity += transform.right* straffeInput * straffeVel;
		//	//rb.velocity = new Vector3(straffeInput, 0.0f, 0.0f);
		//	rb.velocity = directionY;

	//	//}
	//}

	void Run()
	{

		//put stamina check code 
		if (Input.GetKey(KeyCode.LeftShift) && tempStamina <= 0)
		{
			forwardVel = runVel ;
			stat.decreaseStamina();
		}
		if (Input.GetKeyUp(KeyCode.LeftShift))
		{
			forwardVel = walkVel;
		}

		if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
		{
			walking.Play();
		}
		if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
		{
			walking.Pause();
		}

	}


	void OnCollisionStay(Collision other)
	{
		canJump = true;
    }

}
