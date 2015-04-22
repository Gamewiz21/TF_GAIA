using UnityEngine;
using System.Collections;

public class EventManager : MonoBehaviour {

	//public GameObject Bridge;

	public delegate void SignUp();

	public static event SignUp mySignUp;



    void OnGUI () 
    {
      if (mySignUp != null)
      {
          mySignUp();
          GUI.Label(new Rect(5, 5, 150, 40), "HA");

      }
	
	}
 
       /*
   void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Player")
        {
             if (mySignUp != null)
                mySignUp();
             
        }
    }

    */
}
