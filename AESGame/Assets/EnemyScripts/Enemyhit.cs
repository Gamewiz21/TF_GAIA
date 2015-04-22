using UnityEngine;
using System.Collections;

public class Enemyhit : MonoBehaviour {

	AudioSource audioSource;
	public AudioClip audioClip;//Enemy soundClip
		private HealthBar R;//instance of HealthBar

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		audioSource = this.gameObject.GetComponent<AudioSource>();// get the component of audioClip
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		R = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthBar> ();// get component from player
		if (other.gameObject.tag == "Enemy")//if colliding with an enemy
		{
			//play audioClip
			audioSource.PlayOneShot(audioClip);
			R.health -= 20;//decrement health value by 20
		}
	}
}
