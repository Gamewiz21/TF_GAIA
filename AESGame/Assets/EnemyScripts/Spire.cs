using UnityEngine;
using System.Collections;

public class Spire : MonoBehaviour {

    public Transform Path1;
    public Transform Path2;
    public float moveSpeed = 10f;
    public bool cycle;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float moving = moveSpeed * Time.deltaTime;
        Vector2 PatrolPos = new Vector2(Path1.transform.position.x, this.transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, PatrolPos, moving);
        if (this.gameObject.transform.position.x == PatrolPos.x)
        {
            float moveagain = moveSpeed * Time.deltaTime;
            Vector2 PatrolPos2 = new Vector2(Path2.transform.position.x, this.transform.position.y);
            transform.position = Vector2.MoveTowards(transform.position, PatrolPos, moveagain);
            Debug.Log("in");
        }
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        /*
        if (other.gameObject.tag == "spot")
        {
            cycle = true;
            float moving = moveSpeed * Time.deltaTime;
            Vector2 PatrolPos = new Vector2(Path2.transform.position.x, this.transform.position.y);
            transform.position = Vector2.MoveTowards(transform.position, PatrolPos, moving);
            Debug.Log("in");
        }
        if (cycle == true)
        {
            float moving = moveSpeed * Time.deltaTime;
        Vector2 PatrolPos = new Vector2(Path1.transform.position.x, this.transform.position.y);
        transform.position = Vector2.MoveTowards(Path1.transform.position, PatrolPos, moving);

        }
         * */
         
    }
         
}
