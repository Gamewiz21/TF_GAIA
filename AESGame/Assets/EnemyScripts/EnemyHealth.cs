using UnityEngine;
using System.Collections;

public class EnemyHealth : EnemyLifeManager {

	public SwordHitBox hitBox;
	public AudioSource EDeathClip;
	public bool InRange;
    // Use this for initialization

	void Awake() 
	{	// hitbox equals the components from the SwordHitBox script
		hitBox = GameObject.FindGameObjectWithTag("Hitbox").GetComponent<SwordHitBox>(); 

	}

    // Update is called once per frame
    void Update()
    {

		// if the player presses 0 and InRange is set as true
		if (Input.GetKeyDown (KeyCode.O) && InRange == true) 
		{ // enemy loses 30 health
			enemyhealth -= 30;
			//Debug.Log("hit");
		}
		// if enemyhealth equal 0
        if (enemyhealth <= 0)
        { 	// destroy gameObject
			EDeathClip.Play ();
			gameObject.SetActive(false);
        }

    }

   

	void OnTriggerStay2D (Collider2D other)
	{	//if the Hitbox comes in contact with the enemy
		if (other.gameObject.tag == "Hitbox") 
		{	//the target is In Range
			InRange =true;
		}
        if (other.gameObject.tag == "Spell")
        {	//the target is In Range
            enemyhealth -= 20;
            Destroy(other.gameObject);
        }
	}
	void OnTriggerExit2D (Collider2D other)
	{
		// if Outside he is not in range
		InRange =false;
		
	}
}
