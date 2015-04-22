using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {

	public GameObject player;//the player
	public Transform spawnPoint;// Transform of the Spawnpoints
	private HealthBar L;

	public bool isAlive = true;

	private int maxHealth;

	// Use this for initialization
	void Start () 
	{
		player = GameObject.FindGameObjectWithTag ("Player");//play is whatever is tagged player
		L = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthBar> ();//gets the component from player script

		maxHealth = L.health;
	}
	
	// Update is called once per frame
	void Update () 
	{

		// gets script from Player "HealthBar"

		if (L.health <= 0)// if Health = Zero
		{	//L.DeathClip.Play();

			//Instantiate a player clone at the spawnpoints position/ rotation
			//Instantiate(PlayerPrefab,spawnPoint.position, Quaternion.identity);
			player.transform.position = spawnPoint.transform.position;//the player's new position is the Spawnpoint's position
			L.health = maxHealth;// player new health is the max health
			L.isDead = false;
		
		}
	
	}
}
