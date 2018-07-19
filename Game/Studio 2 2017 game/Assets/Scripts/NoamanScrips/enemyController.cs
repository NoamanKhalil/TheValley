using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour {


	public  int currentEnemyHealth  ; 
	public GameObject player;
	public float step;
	bool hasDied;

	public Animator wolfAnimation;
	// Use this for initialization
	void Start () {
		hasDied = false;
		step = 10 * Time.deltaTime;
		currentEnemyHealth = 100;
	}
	
	// Update is called once per frame
	void Update () {


		if ((Vector3.Distance (player.transform.position, this.transform.position) < 20f &&(Vector3.Distance (player.transform.position, this.transform.position) > 5f ) && currentEnemyHealth > 0))
		{
			transform.LookAt (player.transform);
			Vector3.MoveTowards (transform.position, player.transform.position, step);

			Debug.Log ("Movement working");
		}

		if (currentEnemyHealth <= 0 )
		{
			hasDied = true;

		}

		if (hasDied == true) 
		{
			Die ();			
			hasDied = false;
		}

		if((Vector3.Distance(player.transform.position, this.transform.position) < 5f)&& currentEnemyHealth > 0)
		{
			transform.LookAt (player.transform);
			Attack ();
			
		}

	}


	void Die()
	{
		wolfAnimation.Play("Die"); 

	}

	void Attack()
	{
		wolfAnimation.Play ("Attack");
	}
}
