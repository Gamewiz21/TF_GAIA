using UnityEngine;
using System.Collections;

public class LifeCount : MonoBehaviour {
	public int Lives;// Life class
	private HealthBar L;
	public GUIStyle HUD;

	// Use this for initialization
	void Start () {
		Lives = 3;// Number of Lives the player has
		// gets script from Player "HealthBar"
		L = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthBar> ();
	}
	
	// Update is called once per frame
	void Update () {

		if(L.health <= 0)// if player health reaches 0
		{
			Lives-= 1;//decrement health value by one
		}

		if (Lives == 0)// if the player has no lives left
		{
			Application.LoadLevel(1);// the level ends
		}
	
	}
	void OnGUI()
	{	
		GUI.Label(new Rect(50, 500, 300, 150), "Lives: " + Lives,HUD);// Shows number of Lives as a GUI text
		//Note make height 1000 for max screen
		
	}


}
