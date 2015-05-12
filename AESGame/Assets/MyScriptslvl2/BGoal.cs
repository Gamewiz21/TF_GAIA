using UnityEngine;
using System.Collections;

public class BGoal : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D (Collider2D other)
	{	// if player enters collider the 
		if (other.gameObject.tag == "Player")// when player touches collider
		{
			Application.LoadLevel("result2");// go to scene
			
		}
	}
}
