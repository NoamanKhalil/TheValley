using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/// <PlayerStatCs>
/// Authored by Noaman khalil  created In order to control the UI indicators for health , radiation & stamina .
/// </summary>
/// used to control health ,stmina & other player stats 

public class PlayerStatCs : MonoBehaviour
{
	// Health variables to control health bar
	public NightDayCycleCs cy;
	public fadeOutCs fo;
	public float playerStaminaRegenSpeed;
public float attackTime;


	[SerializeField]
	private float health;
	[SerializeField]
	private float maxHealth;
	[SerializeField]
	private Text healthText;
	[SerializeField]
	private Image healthObj;

	//Stamina variables to control stamina bars
	[SerializeField]
	private float stamina;
	[SerializeField]
	private float maxStamina;
	[SerializeField]
	private Text staminaText;
	[SerializeField]
	private Image staminaObj;

	//radiation variables to control radiation bar
	[SerializeField]
	private float radiation;
	[SerializeField]
	private float maxRadiation;
	[SerializeField]
	private Text radiationText;
	[SerializeField]
	private Image radiationObj;

	private bool hasStamina;
	private bool isRunning;
    
    private Animation deathAnim;
	private bool isDead;
	private bool canDie;
    private float dieTime = 2f; 
	private Rigidbody rb; 
	// Use this for initialization
	void Start()
	{//done
		canDie = false;
		isDead = true;
		isRunning = false;

		deathAnim = GetComponent<Animation>();
		rb = GetComponent<Rigidbody>();

		health = maxHealth;
		stamina = maxStamina;
		radiation = maxRadiation;
		healthObj.GetComponent<Image>().fillAmount = health / maxHealth;
		staminaObj.GetComponent<Image>().fillAmount = stamina / maxStamina;
		radiationObj.GetComponent<Image>().fillAmount = 0;


	}

	// Update is called once per frame
	void Update()
	{//dpme
		// used to control text for health /stamina/radiation
		healthText.text = "Health : " + Mathf.RoundToInt( health) + "%";
		staminaText.text = "Stamina : " +Mathf.RoundToInt( stamina) + "%";
		radiationText.text = "Radiation : " +Mathf.RoundToInt(radiation) + "%";
        if (isRunning == false)
		{
			regenStamina();
		}
		//InvokeRepeating("decreaseHealth",1,10);
		die();
	}

	//pete , call this method when you wanna decrease health .

	public void decreaseHealth()
	{//done

        attackTime -= Time.deltaTime;

        if (attackTime <= 0)
        {
            health -= 2.0f;
            healthObj.GetComponent<Image>().fillAmount = health / maxHealth;
            attackTime = 2;
        }

		if (health <= 0 && isDead)
		{
			//transform.Rotate(-Vector3.right, Time.deltaTime);
			isDead = false;
			deathAnim.Play();
			fo.FadeIn();
			canDie = true;


		}

	}

	void die()
	{//die
		if (canDie)
		{
			dieTime -= Time.deltaTime;

			if (dieTime <= 0)
			{
				SceneManager.LoadScene("Scene2");
			}
		}
	}

    public void healthIncrease()
    {//done
        health += 40f;
        healthObj.GetComponent<Image>().fillAmount = health / maxHealth;
    }

	// to be called when running
	public void decreaseStamina()
	{//done
		if (stamina >=1)
		{
			Debug.Log(stamina);
			stamina -= 0.2f;
			staminaObj.GetComponent<Image>().fillAmount = stamina / maxStamina;

		}
	}

	public void regenStamina()
	{//done
		if (stamina < 100.0f && isRunning == false  )
		{
			stamina += Time.deltaTime * playerStaminaRegenSpeed;
			staminaObj.GetComponent<Image>().fillAmount = stamina / maxStamina;
//			Debug.Log(stamina+"Stamina Used");
		}
	}
	public void isRunnuingCheck(bool run)
	{//done
		isRunning = run; 
	}
	// to call radiation , make giant box colliders for the zones which are radiated and call it using in collision enter & exit wll need to make changes here
	public void increaseRadiation()
	{//done
		if (radiation < 100)
		{
			radiation += 0.04f;
			radiationObj.GetComponent<Image>().fillAmount = radiation / 100;
		}
		else
		{
			decreaseHealth();
		}
	}
	//method to access stamina via other scritps 
	public float getStamina(float Stamina)
	{//done
		return stamina;
	}
	void OnTriggerStay(Collider other)
	{//done
		if (other.gameObject.tag == "Radiation")
		{
			Debug.Log("Radiation working ");
            increaseRadiation();
		}
		if (other.gameObject.tag == "indoor")
		{
			cy.PauseRain();
		}
	}

	void OnTriggerExit(Collider other)
	{//done
		if (other.gameObject.tag == "indoor")
		{
			cy.ContinueRain();
		}
	}

	void OnCollisionEnter(Collision col)
	{//dpne
		if (col.gameObject.tag == "Food")
		{
			
		}

	}
}