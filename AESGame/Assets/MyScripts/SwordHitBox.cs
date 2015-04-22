using UnityEngine;
using System.Collections;

public class SwordHitBox : MonoBehaviour {

	public bool InRange = false;

	 void Start()
	{

		
	}
	
	// Update is called once per frame
	void Update () {



		}

	void OnTriggerStay2D (Collider2D other)
	{	//if the Hitbox comes in contact with the enemy
		if (other.gameObject.tag == "Enemy") 
		{	//the target is In Range
			InRange =true;
		}
	}
	void OnTriggerExit2D (Collider2D other)
	{
		// if Outside he is not in range
		InRange =false;

	}


}
