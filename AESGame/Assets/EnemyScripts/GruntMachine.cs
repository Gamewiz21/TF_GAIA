using UnityEngine;
using System.Collections;

public class GruntMachine : MonoBehaviour {
	
	public float SafeDistance = 10f;
	public float dangerZone = 5f;
	public GameObject player;
	public float Speed = 1f;
	public Transform target;
	public float ChaseSpeed = 3f;
	// public Transform target2;
	Animator Anim;
	private HealthBar B;
	private GameObject A;
	bool MoveRight;
	bool MoveLeft;
	//bool SeePlayer;

	enum AIStatus //enumerator indication for enemy status
	{
		Seek = 0,
		Find = 1
		
	}
	private AIStatus status = AIStatus.Seek;
	
	// Use this for initialization
	void Start () {
		
		player = GameObject.FindGameObjectWithTag("Player");// player equals the staus of GM with Player tag 
		B = GameObject.FindGameObjectWithTag ("Player").GetComponent<HealthBar> ();
	}
	
	void CheckStatus()
	{	//dist is the distance between player's location and object this script is attached to
		float dist = Vector3.Distance(player.transform.position, this.transform.position);
		// if distance between is less than awareDistance
		if (dist < dangerZone)
		{	// Ai is in Find Status
			status = AIStatus.Find;
		}
		else if (dist >= SafeDistance)
		{	//AI is in seek status
			status = AIStatus.Seek;
		}
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		// apply method Checkstatus before applying swith statement
		CheckStatus();
		switch (status)
		{
		case AIStatus.Seek:// when player is in Seek status
			// apply Attack method
			Patrol();
			break;
		case AIStatus.Find:// when player is in Find Status
			//apply Hit Method
			Hit();
			break;
		}
		//B = GameObject.FindGameObjectWithTag ("Player").GetComponent<HealthBar> ();
		
	}
	
	void Hit()
	{
		float Attack = ChaseSpeed * Time.deltaTime;
		Vector2 PatrolPos = new Vector2 (player.transform.position.x, this.transform.position.y);
		transform.position = Vector2.MoveTowards(transform.position, PatrolPos,Attack);

		//SeePlayer = new Vector2(player.transform.position, this.transform.position);

		//Anim.SetBool ("PlayerSighted",SeePlayer);
        if (ChaseSpeed >= 1f)
        {
           // Anim.Play ("Assalt");
        }
		
		MoveRight = true;
		MoveLeft = false;


		
	}
	
	void Patrol()
	{
		float patroling = Speed * Time.deltaTime;
		Vector2 PatrolPos = new Vector2 (target.transform.position.x, this.transform.position.y);
		transform.position = Vector2.MoveTowards(transform.position, PatrolPos, patroling);
		MoveRight = true;
		MoveLeft = false;
		
	}
}