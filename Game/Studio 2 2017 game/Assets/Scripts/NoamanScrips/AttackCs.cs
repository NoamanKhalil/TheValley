using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCs : MonoBehaviour
{
	//public GameObject treeBeingCut;
	private Animation axeAnim;
	public ParticleSystem ps;
	// Use this for initialization
	void Start()
	{
		axeAnim = GetComponent<Animation>();
	}
	public void playPartiles()
	{
		ps.Play();
	}
	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButton(0) && axeAnim.isPlaying == false)
		{
			axeAnim.Play();
		}
	}

}