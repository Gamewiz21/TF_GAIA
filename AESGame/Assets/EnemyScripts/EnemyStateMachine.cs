using UnityEngine;
using System.Collections;

public class EnemyStateMachine : MonoBehaviour
{
    private PlatformerCharacter2D Turn;
    public float SafeDistance = 6f;
    public float dangerZone = 5f;
    public GameObject player;
    public float Speed = 1f;
    public Transform target;
	public float ChaseSpeed = 3f;
   // public Transform target2;
	private HealthBar B;
	private GameObject A;
    bool MoveRight;
    bool MoveLeft;
	//bool Gone = false;
    enum AIStatus //enumerator indication for enemy status
    {
        Seek = 0,
        Find = 1

    }
    private AIStatus status = AIStatus.Seek;

	// Use this for initialization
	void Start () 
    {
       
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
        player = GameObject.FindGameObjectWithTag("Player");// player equals the staus of GM with Player tag 
        B = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthBar>();
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
        Turn = GameObject.Find("2D Character").GetComponent<PlatformerCharacter2D>();
        
	}

    void Hit()
    {
		float Attack = ChaseSpeed * Time.deltaTime;
		Vector2 PatrolPos = new Vector2 (player.transform.position.x, this.transform.position.y);
		transform.position = Vector2.MoveTowards(transform.position, PatrolPos,Attack);
       
        if (Turn.facingRight == false)// if player isn't facing right
        {
            MoveRight = true;
            transform.rotation = Quaternion.Euler(0, 180, 0);// rotate 180 degrees left
            MoveLeft = false;
        }

        if (Turn.facingRight == true)// if player is facing rightn
        {
            MoveLeft = true;
            transform.rotation = Quaternion.Euler(0, 0, 0);// maintain 
            MoveRight = false;
        }

    }

    void Patrol()
    {
         float patroling = Speed * Time.deltaTime;// patroling speed
		Vector2 PatrolPos = new Vector2 (target.transform.position.x, this.transform.position.y);// PatrolPos is the distance between target and enemy
         transform.position = Vector2.MoveTowards(transform.position, PatrolPos, patroling);// move toward the object based on the speed value of Patrol Pos
         //transform.rotation = Quaternion.Euler(0, -180, 0);
        
       
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Target")
        {
           
        }
    }
}
