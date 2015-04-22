using UnityEngine;
using System.Collections;

public class EventListener : MonoBehaviour {

    bool Reading;

	void OnEnabled() 
	{
		EventManager.mySignUp += mySignUp;
	}
	void OnDisabled()
	{
		EventManager.mySignUp -= mySignUp;
	}

    void mySignUp()
    {
       if( Reading == true)
        Debug.Log("Gather Crystals");

    }

    /*
    void OnGUI()
    {
        if(Reading == true)
        {
            GUI.Label(new Rect(5, 5, 150, 40), "HA");
        }
            
   }
     */
      void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Player")
        {
            Reading = true;
            mySignUp();
        }
    }
		
}
