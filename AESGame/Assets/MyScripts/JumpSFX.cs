using UnityEngine;
using System.Collections;

public class JumpSFX : MonoBehaviour {

	public AudioSource Jump;//instance of AudioSource
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown (KeyCode.Space))
		{
			if(!Jump.isPlaying)//if not already playing
				Jump.Play ();// play Clip
		}
	
	}
}
