using UnityEngine;
using System.Collections;

public class Fireballshoot : MonoBehaviour {

	public Rigidbody2D FirePrefab;// instance of fireball prefab
	public Transform Hand;// location of instantation 
	public float force = 10.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.P))// if the P key is pressed
		{
			Rigidbody2D ShotInstance;// instance of rigidbody2D
			ShotInstance = Instantiate(FirePrefab,Hand.position,Hand.rotation) as Rigidbody2D;// Instantiate at Hand's position at its rotation
                    
				ShotInstance.AddForce(Hand.right * force);// Add force to the instantated object times the value of force
				Destroy (ShotInstance.gameObject, 1);// destroy object after one second

		}
	
	}
}
