using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AIBehaviorForObject : MonoBehaviour {

    float wait = 0.7f;

    

    public Nodes rootnode;
    public float dist;
    public GameObject AI;
    public GameObject Player;
    public AudioSource attacksound;
    public AudioSource chasesound;
    public AIChase chase;
    public AIAttack attack;
    public Nodes sequence;
    public Nodes sequence1;
    public Nodes sequence2;
    public Nodes selector2;
   

   

    // Use this for initialization
    void Start ()
    {
        AI = this.gameObject;
        Player = GameObject.FindGameObjectWithTag("Player");
        chase = new AIChase();
        attack = new AIAttack();
      

       // ph = new AIPlayerHide();
        sequence = new AISequence();
        sequence1 = new AISequence();
        sequence2 = new AISequence();
        rootnode = new AInodeselector();
        selector2 = new AInodeselector();


        //rootnode = chase;
        // AISequence Sequence1 = new AISequence(); 

        rootnode.AIB = this;
       rootnode.AddChild(sequence);
       // selector2.AddChild(sequence);
        sequence.AddChild(chase);
        sequence.AddChild(attack);
        
     
      
        
        
       
        //rootnode.AddChild(ph);
       // rootnode.AddChild(chase);
        //rootnode.AddChild(Sequence1);
       // rootnode.AddChild(attack);

               
        
       
        //rootnode.AddChild(AiSequence1);
        //rootnode.AddChild(wander);
        
        //AiSequence1.AddChild(chase);

    }
	
	// Update is called once per frame
	void Update ()
    {
        dist = AIrangecheck();
        if (dist <= 20)
        {
          rootnode.ActionExecute();
        }
        else
        {
            return;
        }
       
        //wait -= Time.deltaTime;
        //if (wait <= 0f)
        //{
        
        //    wait = 0.1f;
        //}
        

    }
    public float AIrangecheck()
    {
        float dist;
        dist = Vector3.Distance(Player.transform.position, AI.transform.position);

        return dist;
    }
}
