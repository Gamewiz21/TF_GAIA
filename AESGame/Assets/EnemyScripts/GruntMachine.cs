using UnityEngine;
using System.Collections;

public class GruntMachine : MonoBehaviour
{
    private PlatformerCharacter2D Turn;
    bool facingRight = true;
    public float SafeDistance = 6f;
    public float dangerZone = 5f;
    public GameObject player;
    public float Speed = 1f;
    public Transform target;
    public float ChaseSpeed = 3f;
    // public Transform target2;
    public Animator anim;
    private HealthBar B;
    private GameObject A;
    bool MoveRight;
    bool MoveLeft;
    float move;
    enum AIStatus //enumerator indication for enemy status
    {
        Seek = 0,
        Find = 1

    }
    private AIStatus status = AIStatus.Seek;

    // Use this for initialization
    void Start()
    {
        
        anim = GetComponent<Animator>();// get component from animator
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
    void Update()
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

        // Move the character **
        rigidbody2D.velocity = new Vector2(move * ChaseSpeed, rigidbody2D.velocity.y);
        Turn = GameObject.Find("2D Character").GetComponent<PlatformerCharacter2D>();
    }

    void Hit()
    {
        float Attack = ChaseSpeed * Time.deltaTime;
        Vector2 PatrolPos = new Vector2(player.transform.position.x, this.transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, PatrolPos, Attack);
        anim.Play("Assalt");

        if (Turn.facingRight == false)// if player isn't facing right
        {
            MoveRight = true;
            transform.rotation = Quaternion.Euler(0, 0, 0);// rotate 180 degrees left
            MoveLeft = false;
        }

        if (Turn.facingRight == true)// if player is facing right
        {
            MoveLeft = true;
            transform.rotation = Quaternion.Euler(0, 180, 0);// maintain position
            MoveRight = false;
        }

    }

    void Patrol()
    {
        float patroling = Speed * Time.deltaTime;
        Vector2 PatrolPos = new Vector2(target.transform.position.x, this.transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, PatrolPos, patroling);
        MoveRight = true;
        MoveLeft = false;
        anim.Play("moving");
    }
    void Flip()//**
    {
        // Switch the way the player is labelled as facing.
        facingRight = !facingRight;

        // Multiply the player's x local scale by -1.
        Vector2 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}