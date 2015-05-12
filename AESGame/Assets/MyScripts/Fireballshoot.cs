using UnityEngine;
using System.Collections;

public class Fireballshoot : MonoBehaviour 
{

	public Rigidbody2D FirePrefab;// instance of fireball prefab
	public Transform Hand;// location of instantation 
	public float force = 10.0f;
    private PlatformerCharacter2D Turn;
    public int FireAmmo = 10;
    public GUIStyle HUD;
	// Update is called once per frame
	void Update ()
         {
             Turn = GameObject.Find("2D Character").GetComponent<PlatformerCharacter2D>();
		if (Input.GetKeyDown (KeyCode.P) && Turn.facingRight == true) 

            if(FireAmmo > 0)
            {// if the P key is pressed
			Rigidbody2D ShotInstance;// instance of rigidbody2D
			ShotInstance = Instantiate (FirePrefab, Hand.position, Hand.rotation) as Rigidbody2D;
            // Instantiate at Hand's position at its rotation
           
			   // Hand.rotation = Quaternion.Euler(new Vector3(0,0,0));
			    ShotInstance.AddForce (Hand.right * force);// Add force to the instantated object times the value of force
                FireAmmo--;
			    Destroy (ShotInstance.gameObject, 1);// destroy object after one second
                
		    }
         if (Input.GetKeyDown(KeyCode.P) && Turn.facingRight == false)
                if(FireAmmo > 0)
		    {
                //this.transform.Rotate(0, 180, 0);
                Rigidbody2D ShotInstance;
                ShotInstance = Instantiate(FirePrefab, Hand.position, Hand.rotation) as Rigidbody2D;
			    ShotInstance.AddForce (-Hand.right * force);// Add force to the instantated object times the value of force
                FireAmmo--;
			    Destroy (ShotInstance.gameObject, 1);// destroy object after one second
                
		    }

             if (FireAmmo <= 0)
                 {
                     Nothing(); // don't Instantiate, do nothing when p is pressed
                 }
        }

    void Nothing()
    { }

    void OnGUI()
    {
        GUI.Label(new Rect ( 10, 50, 500, 500), "Mana:" + FireAmmo, HUD);// show mana value as GUI text
    }

    
	
}
