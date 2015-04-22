using UnityEngine;
using System.Collections;

public class Slashsound : MonoBehaviour {
	
	public AudioSource Hit;//instance of AudioSource
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown (KeyCode.O))// if o is pressed
		{
			if(!Hit.isPlaying)//if not already playing
				Hit.Play ();// play Clip
		}
		
	}
}
