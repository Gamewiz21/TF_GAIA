using UnityEngine;
using System.Collections;

public class TryAgain : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        if (GUI.Button(new Rect(120, 140, 80, 20), "Yes"))// if Yes Button is pressed
        {
            Application.LoadLevel(0);// go to Main menu
        }

        // Make the second button.
        if (GUI.Button(new Rect(120, 170, 80, 20), "No"))// if no button is pressed
        {
            Application.Quit();// Quit Game
            
        }
    }
}
