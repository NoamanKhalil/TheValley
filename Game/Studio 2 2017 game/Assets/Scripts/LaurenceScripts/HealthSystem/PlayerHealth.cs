using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public float MaxHealth = 100f;
    public float CurrentHealth = 0f;
    public GameObject healthbar;
    public GameObject HealthShow;
    public GameObject player;
    public GameObject enemy;
	public GameManagerCS gm; 
    float dist;
    Animator anamator;
    LayerMask enemylayer;
    public AudioSource attack, chase;
    public GameObject food;

	// Use this for initialization
	void Start ()
    {
        CurrentHealth = MaxHealth;
        anamator = enemy.GetComponent<Animator>();
		player = gm.PlayerObject; 
        // InvokeRepeating("decreaseHP",1f,1f);
    }
	
	// Update is called once per frame
	void Update ()
    {
       // RaycastHit hit;
       // var fwd = (player.transform.TransformDirection(Vector3.forward));
       // dist = Physics.Raycast(player.transform.position,enemy.transform.position,6f,enemylayer, );
        dist = Vector3.Distance(enemy.transform.position, player.transform.position);
        if (dist < 2.5f && Input.GetKeyDown(KeyCode.Mouse0))
        {
            decreaseHP();
        }
		if (CurrentHealth <= 0f)
        {
            Debug.Log("dead");
            
            enemy.gameObject.GetComponent<BoidOptimized>().enabled = false;
            enemy.gameObject.GetComponent<AIBehaviorForObject>().enabled = false;
            anamator.SetInteger("WolfState", 4);
            anamator.StopPlayback();
            HealthShow.SetActive(false);
            attack.Pause();
            chase.Pause();
            food.SetActive(true);
            if (food != null)
            {
                return;
            }
          
           

           
            
        }
	}
    void decreaseHP()
    {
        CurrentHealth -= 30f;
        float calculatedHP = CurrentHealth / MaxHealth;
        sethealthbar(calculatedHP);
    }
    public void sethealthbar(float myhealth)
    {
        // myhealth
        healthbar.transform.localScale = new Vector3(myhealth, healthbar.transform.localScale.y, healthbar.transform.localScale.z);
    }
}
