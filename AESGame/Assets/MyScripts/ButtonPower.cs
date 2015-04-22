using UnityEngine;
using System.Collections;

public class ButtonPower : MonoBehaviour {
	// Floor panel gameObjects
	public GameObject Floor1;
	public GameObject Floor2;
	public GameObject Floor3;
	public bool CanBePressed = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		//when G is pressed and the player is within the collider
		if(Input.GetKeyDown(KeyCode.G) && CanBePressed == true)
		   {
			//the previously inActive floors will become Active
			Floor1.SetActive(true);
			Floor2.SetActive(true);
			Floor3.SetActive(true);
		}
		
	
	}

	void OnTriggerEnter2D (Collider2D other)
	{ 	// when the Player enters the collider
		if(other.gameObject.tag == "Player")
		{ // this will be true
			CanBePressed = true;
		}

	}
	void OnTriggerExit2D (Collider2D other)
	{// outside the collider it will be false
		CanBePressed = false;
	}
}
