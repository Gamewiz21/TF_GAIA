using UnityEngine;
using System.Collections;

public class Fireballshoot : MonoBehaviour 
{

	public Rigidbody2D FirePrefab;// instance of fireball prefab
	public Transform Hand;// location of instantation 
	public float force = 10.0f;
    private PlatformerCharacter2D Turn;
	// Update is called once per frame
	void Update ()
         {
             Turn = GameObject.Find("2D Character").GetComponent<PlatformerCharacter2D>();
		if (Input.GetKeyDown (KeyCode.P) && Turn.facingRight == true) 
            {// if the P key is pressed
			Rigidbody2D ShotInstance;// instance of rigidbody2D
			ShotInstance = Instantiate (FirePrefab, Hand.position, Hand.rotation) as Rigidbody2D;
            // Instantiate at Hand's position at its rotation
           
			   // Hand.rotation = Quaternion.Euler(new Vector3(0,0,0));
			    ShotInstance.AddForce (Hand.right * force);// Add force to the instantated object times the value of force
			    Destroy (ShotInstance.gameObject, 1);// destroy object after one second
                
		    }
        else if (Input.GetKeyDown(KeyCode.P) && Turn.facingRight == false)
		    {
                //this.transform.Rotate(0, 180, 0);
                Rigidbody2D ShotInstance;
                ShotInstance = Instantiate(FirePrefab, Hand.position, Hand.rotation) as Rigidbody2D;
			    ShotInstance.AddForce (-Hand.right * force);// Add force to the instantated object times the value of force
			    Destroy (ShotInstance.gameObject, 1);// destroy object after one second
                
		    }
        }

    
	
}
