//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class FPSForceMove : MonoBehaviour
//{
//<<<<<<< HEAD
////<<<<<<< HEAD

////    //	public GameObject wolf;
////    //	public AudioSource walking;
////    //    public float inputDelay;

////    //	private float forwardVel;
////    //	public float straffeVel;
////    //	public float jumpVel = 44f;
////    //	private float walkVel = 8f;
////    //	public float runVel = 36f;

////    //	public GameObject treeBeingCut;
//=======


////    //	public GameObject wolf;
////    //	public AudioSource walking;
////    //    public float inputDelay;

////    //	private float forwardVel;
////    //	public float straffeVel;
////    //	public float jumpVel = 44f;
////    //	private float walkVel = 8f;
////    //	public float runVel = 36f;
//>>>>>>> e98636cba6ebe66dba6d462da2553260b7591b71

////    //	public GameObject treeBeingCut;

//<<<<<<< HEAD
////    //	Rigidbody rb;
////    //	float forwardInput, straffeInput;
//=======
//>>>>>>> e98636cba6ebe66dba6d462da2553260b7591b71

////    //	Rigidbody rb;
////    //	float forwardInput, straffeInput;


//<<<<<<< HEAD
////    //    private float tempStamina;

////    //    bool isPlaying;

////    //	private PlayerStatCs stat;

////    //	private bool canJump;

////    //	void Start()
////    //	{
////    //		stat = GetComponent<PlayerStatCs>();
////    //		treeBeingCut = null;
////    //		rb = GetComponent<Rigidbody>();
////    //		forwardInput = straffeInput = 0;
////    //		isPlaying = false;
////    //		wolf = null;

////    //		Cursor.lockState = CursorLockMode.Locked;
////    //		Cursor.visible = false;

////    //		forwardVel = walkVel;
////    //	}
//=======

////    //    private float tempStamina;

////    //    bool isPlaying;

////    //	private PlayerStatCs stat;

////    //	private bool canJump;

////    //	void Start()
////    //	{
////    //		stat = GetComponent<PlayerStatCs>();
////    //		treeBeingCut = null;
////    //		rb = GetComponent<Rigidbody>();
////    //		forwardInput = straffeInput = 0;
////    //		isPlaying = false;
////    //		wolf = null;

////    //		Cursor.lockState = CursorLockMode.Locked;
////    //		Cursor.visible = false;
//>>>>>>> e98636cba6ebe66dba6d462da2553260b7591b71

////    //		forwardVel = walkVel;
////    //	}


//<<<<<<< HEAD
////    //	void Update()
////    //	{
////    //		stat.getStamina(tempStamina);
////    //		Run();

////    //		forwardInput = Input.GetAxis("Vertical");
////    //		straffeInput = Input.GetAxis("Horizontal");
////    //		// code to play audio /pasue it 
////    //		if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
////    //		{
////    //			walking.Play();
////    //		}
////    //		if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
////    //		{
////    //			walking.Pause();
////    //		}

////    //		//Jump code
////    //		if (canJump& Input.GetKeyUp(KeyCode.Space))
////    //		{

////    //			//rb.velocity += transform.up* jumpVel;
////    //			rb.velocity =new Vector3(rb.velocity.x, jumpVel, rb.velocity.y);
////    //			//rb.AddForce(new Vector3(0, 100, 0), ForceMode.Impulse);
////    //			canJump = false;
////    //		}

////    //	}

////    //	void FixedUpdate()
////    //	{

////    //		if (Mathf.Abs(forwardInput) > inputDelay)
////    //		{

////    //			//rb.velocity = new Vector3(0.0f, 0.0f, forwardInput);
////    //			rb.velocity = transform.forward * forwardInput * forwardVel;

////    //		}
//=======

////    //	void Update()
////    //	{
////    //		stat.getStamina(tempStamina);
////    //		Run();

////    //		forwardInput = Input.GetAxis("Vertical");
////    //		straffeInput = Input.GetAxis("Horizontal");
////    //		// code to play audio /pasue it 
////    //		if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
////    //		{
////    //			walking.Play();
////    //		}
////    //		if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
////    //		{
////    //			walking.Pause();
////    //		}

////    //		//Jump code
////    //		if (canJump& Input.GetKeyUp(KeyCode.Space))
////    //		{

////    //			//rb.velocity += transform.up* jumpVel;
////    //			rb.velocity =new Vector3(rb.velocity.x, jumpVel, rb.velocity.y);
////    //			//rb.AddForce(new Vector3(0, 100, 0), ForceMode.Impulse);
////    //			canJump = false;
////    //		}

////    //	}

////    //	void FixedUpdate()
////    //	{

////    //		if (Mathf.Abs(forwardInput) > inputDelay)
////    //		{

////    //			//rb.velocity = new Vector3(0.0f, 0.0f, forwardInput);
////    //			rb.velocity = transform.forward * forwardInput * forwardVel;
//>>>>>>> e98636cba6ebe66dba6d462da2553260b7591b71

////    //		}

//<<<<<<< HEAD
////    //		if (Mathf.Abs(straffeInput) > inputDelay)
////    //		{
////    //			rb.velocity += transform.right* straffeInput * straffeVel;

////    //			//rb.velocity = new Vector3(straffeInput, 0.0f, 0.0f);
////    //		}
////    //		//float moveHorizontal = Input.GetAxis("Horizontal");
////    //		//float moveVertical = Input.GetAxis("Vertical");
////    //		//float speed = 10.0f;
////    //		//Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
////    //		//rb.velocity = movement* speed;

////    //	}
//=======

////    //		if (Mathf.Abs(straffeInput) > inputDelay)
////    //		{
////    //			rb.velocity += transform.right* straffeInput * straffeVel;

////    //			//rb.velocity = new Vector3(straffeInput, 0.0f, 0.0f);
////    //		}
////    //		//float moveHorizontal = Input.GetAxis("Horizontal");
////    //		//float moveVertical = Input.GetAxis("Vertical");
////    //		//float speed = 10.0f;
////    //		//Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
////    //		//rb.velocity = movement* speed;
//>>>>>>> e98636cba6ebe66dba6d462da2553260b7591b71

////    //	}

//<<<<<<< HEAD
////    //    void GetInput()
////    //    {
////    //        forwardInput = Input.GetAxis("Vertical");
////    //        straffeInput = Input.GetAxis("Horizontal");
////    //    }
//=======
//>>>>>>> e98636cba6ebe66dba6d462da2553260b7591b71

////    //    void GetInput()
////    //    {
////    //        forwardInput = Input.GetAxis("Vertical");
////    //        straffeInput = Input.GetAxis("Horizontal");
////    //    }


//<<<<<<< HEAD
////    //    void Walk()
////    //    {
////    //        if (Mathf.Abs(forwardInput) > inputDelay)
////    //        {
////    //            rb.velocity = transform.forward * forwardInput * forwardVel;
////    //        }
////    //        else
////    //        {
////    //            rb.velocity = Vector3.zero;
////    //        }

////    //    }

////    //    void Straffe()
////    //    {
////    //        if (Mathf.Abs(straffeInput) > inputDelay)
////    //        {
////    //            rb.velocity += transform.right * straffeInput * straffeVel;
////    //        } 
////    //    }



////    // //   public void Run()
////    // //   {

////    // //       //put stamina check code 
////    // //       if (Input.GetKey(KeyCode.LeftShift) && tempStamina <= 1)
////    // //       {
////    // //           forwardVel = runVel;
////    // //           stat.decreaseStamina();
////    // //       }
////    // //       else if (Input.GetKeyUp(KeyCode.LeftShift))
////    // //       {
////    // //           forwardVel = walkVel;
////    // //       }



////    //	//	if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
////    //	//	{
////    //	//		walking.Play();
////    //	//	}
////    //	//	if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
////    //	//	{
////    //	//		walking.Pause();
////    //	//	}

////    //	//}
//=======

////    //    void Walk()
////    //    {
////    //        if (Mathf.Abs(forwardInput) > inputDelay)
////    //        {
////    //            rb.velocity = transform.forward * forwardInput * forwardVel;
////    //        }
////    //        else
////    //        {
////    //            rb.velocity = Vector3.zero;
////    //        }

////    //    }
//>>>>>>> e98636cba6ebe66dba6d462da2553260b7591b71

////    //    void Straffe()
////    //    {
////    //        if (Mathf.Abs(straffeInput) > inputDelay)
////    //        {
////    //            rb.velocity += transform.right * straffeInput * straffeVel;
////    //        } 
////    //    }



////    // //   public void Run()
////    // //   {

////    // //       //put stamina check code 
////    // //       if (Input.GetKey(KeyCode.LeftShift) && tempStamina <= 1)
////    // //       {
////    // //           forwardVel = runVel;
////    // //           stat.decreaseStamina();
////    // //       }
////    // //       else if (Input.GetKeyUp(KeyCode.LeftShift))
////    // //       {
////    // //           forwardVel = walkVel;
////    // //       }



////    //	//	if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
////    //	//	{
////    //	//		walking.Play();
////    //	//	}
////    //	//	if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
////    //	//	{
////    //	//		walking.Pause();
////    //	//	}

////    //	//}



//<<<<<<< HEAD
////    //	public void Run()
////    //	{

////    //		//put stamina check code 
////    //		if (Input.GetKey(KeyCode.LeftShift) && tempStamina <= 1)
////    //		{
////    //			forwardVel = runVel;
////    //			stat.decreaseStamina();
////    //		}
////    //		else if (Input.GetKeyUp(KeyCode.LeftShift))
////    //		{
////    //			forwardVel = walkVel;
////    //		}
////    //<<<<<<< HEAD

//=======

////    //	public void Run()
////    //	{

////    //		//put stamina check code 
////    //		if (Input.GetKey(KeyCode.LeftShift) && tempStamina <= 1)
////    //		{
////    //			forwardVel = runVel;
////    //			stat.decreaseStamina();
////    //		}
////    //		else if (Input.GetKeyUp(KeyCode.LeftShift))
////    //		{
////    //			forwardVel = walkVel;
////    //		}
////    //<<<<<<< HEAD

//>>>>>>> e98636cba6ebe66dba6d462da2553260b7591b71
////    //		if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
////    //		{
////    //			walking.Play();
////    //		}
////    //		if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
////    //		{
////    //			walking.Pause();
////    //		}

////    //	}


////    //     void OnCollisionStay(Collision other)
////    //	{
////    //		canJump = true;
////    //	}
////    //}

////    //        //put stamina check code 
////    //        if (Input.GetKey(KeyCode.LeftShift) && tempStamina <= 1 && Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
////    //        {
////    //            forwardVel = runVel;
////    //            stat.decreaseStamina();
////    //            stat.isRunnuingCheck(true);
////    //        }
////    //        if (Input.GetKeyUp(KeyCode.LeftShift))
////    //        {
////    //            stat.isRunnuingCheck(false);
////    //        }


////    //    }
////    //}

////    //void OnCollisionStay (Collision col)
////    //{
////    //	if (col.gameObject.tag == "tree") 
////    //	{
////    //		Debug.Log ("can cut");
////    //		GetComponentInChildren<AttackCs>().cuttingTree = true;
////    //		treeBeingCut = col.gameObject;

////    //	}
////    //}

////    //void OnTriggerStay (Collider col) 
////    //{
////    //	if (col.gameObject.tag == "Wolf")
////    //	{
////    //		Debug.Log ("can attack");
////    //		wolf = col.gameObject;
////    //		GetComponentInChildren<AttackCs> ().attacking = true;

////    //	}
////    //}


////    /*void OnCollisionStay (Collision col)
////    {
////        if (col.gameObject.tag == "tree") 
////        {
////            Debug.Log ("can cut");
////            GetComponentInChildren<AttackCs>().cuttingTree = true;
////            treeBeingCut = col.gameObject;
////    >>>>>>> 7dfa0fb5de278ca9b93c512cd2375c0e3cd93790


////        private PlayerStatCs stat;

////        private float tempStamina;
////        //bool isPlaying;
////        private bool isPlaying;


////        void Start()
////        {
////            stat = GetComponent<PlayerStatCs>();
////            treeBeingCut = null;
////            rb = GetComponent<Rigidbody>();
////            forwardInput = straffeInput = 0;
////            isPlaying = false;
////            wolf = null;

////            Cursor.lockState = CursorLockMode.Locked;
////            Cursor.visible = false;

////            forwardVel = walkVel;
////        }



////        void GetInput()
////        {
////            forwardInput = Input.GetAxis("Vertical");
////            straffeInput = Input.GetAxis("Horizontal");
////        }

////        void Update()
////        {
////            stat.getStamina(tempStamina);
////            GetInput();
////            Run();


////            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
////            {
////                walking.Play();
////            }
////            if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
////            {
////                walking.Pause();
////            }

////        }

////        void FixedUpdate()
////        {
////            Walk();
////            Straffe();
////        }

////        void Walk()
////        {
////            if (Mathf.Abs(forwardInput) > inputDelay)
////            {
////                rb.velocity = transform.forward * forwardInput * forwardVel;
////            }
////            else
////            {
////                rb.velocity = Vector3.zero;
////            }

////        }

////        void Straffe()
////        {
////            if (Mathf.Abs(straffeInput) > inputDelay)
////            {
////                rb.velocity += transform.right * straffeInput * straffeVel;
////            }
////        }



////        public void Run()
////        {
////            //      else if (Input.GetKeyUp(KeyCode.LeftShift))
////            //{
////            //	forwardVel = walkVel;
////            //}
////            //put stamina check code 
////            if (Input.GetKey(KeyCode.LeftShift) && tempStamina <= 1 && Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
////            {
////                forwardVel = runVel;
////                stat.decreaseStamina();
////                stat.isRunnuingCheck(true);
////            }
////            if (Input.GetKeyUp(KeyCode.LeftShift))
////            {
////                stat.isRunnuingCheck(false);
////            }
////        }


////        void OnCollisionStay(Collision col)
////        {
////            if (col.gameObject.tag == "tree")
////            {
////                Debug.Log("can cut");
////                GetComponentInChildren<AttackCs>().cuttingTree = true;
////                treeBeingCut = col.gameObject;

////            }
////        }

////        void OnTriggerStay(Collider col)
////        {
////            if (col.gameObject.tag == "Wolf")
////            {
////                Debug.Log("can attack");
////                wolf = col.gameObject;
////                GetComponentInChildren<AttackCs>().attacking = true;

////            }
////        }



////    }*/
////}
////=======
////	public GameObject wolf;
////	public AudioSource walking;
////    public float inputDelay;

////    private float forwardVel;
////	private Vector3 direction;
////    public float straffeVel;
////    private float walkVel = 8f;
////    public float runVel = 36f;
////	public float jumpVel = 200.0f;
////    public GameObject treeBeingCut;
////    Rigidbody rb;
////    float forwardInput, straffeInput;
////    private PlayerStatCs stat;
////    private float tempStamina;
////    bool isPlaying;
////	bool canJump;

////	void Start()
////	{
////		stat = GetComponent<PlayerStatCs>();
////		treeBeingCut = null;
////		rb = GetComponent<Rigidbody>();
////		forwardInput = straffeInput = 0;
////		isPlaying = false;
////		wolf = null;

////		Cursor.lockState = CursorLockMode.Locked;
////		Cursor.visible = false;

////		forwardVel = walkVel;
////	}

////	void Update()
////	{
////		stat.getStamina(tempStamina);
////		Run();

////		forwardInput = Input.GetAxis("Vertical") * forwardVel;
////		straffeInput = Input.GetAxis("Horizontal")*forwardVel;


////		direction =  new Vector3(straffeInput,rb.velocity.y, forwardInput);
////		// code to play audio /pasue it 
////		if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
////		{
////			walking.Play();
////		}
////		if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
////		{
////			walking.Pause();
////		}
////		if (Mathf.Abs(forwardInput) > inputDelay)
////		{
////			//rb.velocity = new Vector3(0.0f, 0.0f, forwardInput);
////			//rb.velocity = transform.forward * forwardInput * forwardVel;
////			rb.velocity = direction;

				
////		}
////		//Jump code
////		if (canJump& Input.GetKeyUp(KeyCode.Space))
////		{

////			//rb.velocity += transform.up* jumpVel;
////			//rb.velocity =new Vector3(0, jumpVel, 0);
////			rb.AddForce(new Vector3(0, jumpVel, 0), ForceMode.Impulse);
////			canJump = false;
////		}

////	}

////	void FixedUpdate()
////	{
			
////		//if (Mathf.Abs(forwardInput) > inputDelay)
////		//{
////		//	//rb.velocity = new Vector3(0.0f, 0.0f, forwardInput);
////		//	//rb.velocity = transform.forward * forwardInput * forwardVel;
////		//	rb.velocity = direction;

				
////		//}
////		//if (Mathf.Abs(straffeInput) > inputDelay)
////		//{
////		//	//rb.velocity += transform.right* straffeInput * straffeVel;
////		//	//rb.velocity = new Vector3(straffeInput, 0.0f, 0.0f);
////		//	rb.velocity = directionY;
				
////		//}
////	}

////	 void Run()
////	{

////		//put stamina check code 
////		if (Input.GetKey(KeyCode.LeftShift) && tempStamina <= 1)
////		{
////			forwardVel = runVel;
////			stat.decreaseStamina();
////		}
////		else if (Input.GetKeyUp(KeyCode.LeftShift))
////		{
////			forwardVel = walkVel;
////		}

////		if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
////		{
////			walking.Play();
////		}
////		if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
////		{
////			walking.Pause();
////		}

////	}


////     void OnCollisionStay(Collision other)
////	{
////		canJump = true;
////	}
////}
////>>>>>>> 5eba490c3ffffd50aab44f88fb2e6c95d0ee8743
