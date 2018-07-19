using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIChase : Nodes
{


	public float targetdistance;
	public GameObject Player;
	public GameObject Ai;
	public int FieldOfview;
	public float dist1 = 10;
	// private AInodecontroller NC;
	public AIAttack Attack;
	Animator aianimator;
	//GameObject pathfinding;

	public AudioSource chase;

	public Vector3[] pathtofollow;



	public override void ActionExecute()
	{
		AIB = AIB.gameObject.GetComponent<AIBehaviorForObject>();
		Ai = AIB.AI;

		Player = AIB.Player;
		chase = AIB.chasesound;

        
        dist1 = AIrangecheck();

		aianimator = Ai.GetComponent<Animator>();

		if (dist1 <= 3f)
		{

			Success();

			return;
		}
		if (dist1 <= 15f)
		{
			// Success();
			Running();

			Ai.GetComponent<BoidOptimized>().enabled = false;

			aianimator.SetInteger("WolfState", 3);
			chase.Play();

		}
		else
		{
			Failed();
			Ai.GetComponent<BoidOptimized>().enabled = true;
			aianimator.SetInteger("WolfState", 0);
			chase.Pause();

			return;
		}
		Running();
		// pathtofollow = PathFinding.instance.showMeTheWay(AIB.transform, Player.transform);

		Ai.transform.LookAt(Player.transform.position, Vector3.up);
		Ai.transform.position = Vector3.MoveTowards(Ai.transform.position, Player.transform.position, (6 * Time.deltaTime));

	}


	public float AIrangecheck()
	{
		float dist;
		Player = AIB.Player;
		Ai = AIB.AI;
		dist = Vector3.Distance(Player.transform.position, Ai.transform.position);

		return dist;
	}
}