using UnityEngine;
using System.Collections;

public class HazardSfx : MonoBehaviour {

	public AudioSource DamageClip;//AudioSource instance

	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.gameObject.tag == "Player")//is player collides with object
		{
			DamageClip.Play ();//play clip
		}
	}

}
