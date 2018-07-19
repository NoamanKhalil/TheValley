using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIAttack : Nodes {

    public GameObject Player;
    public GameObject Ai;
    Animator aianimator;
    MonoBehaviour time;
    public AudioSource attack;

    public override void ActionExecute()
    {
        float dist1 = 5;
        Ai = AIB.AI;
        attack = AIB.attacksound;
        Player = AIB.Player;
        distcheck();

         

        dist1 = distcheck();
        Running();
        // Success();

        if (dist1 <= 3f)
        {

            Success();

            

            aianimator = Ai.GetComponent<Animator>();
            aianimator.SetInteger("WolfState", 2);
            attack.Play();
            
                Player.GetComponent<PlayerStatCs>().decreaseHealth();
               
            
          
           
            //aianimator.SetBool("IsRun", false);
           // aianimator.SetBool("IsAttack", true);
           // Cursor.visible = true;
          //  Screen.lockCursor = false;

			
       
            
        }

        else
        {
            Failed();
            attack.Pause();
        }

            base.ActionExecute();
    }

    

    private float distcheck()
    {
        float dist = Vector3.Distance(Player.transform.position, Ai.transform.position);
        return dist;
    }

   /*  IEnumerator die ()
            {

                yield return new WaitForSeconds(7);
                Application.LoadLevel("WinLose");
            }*/
}
