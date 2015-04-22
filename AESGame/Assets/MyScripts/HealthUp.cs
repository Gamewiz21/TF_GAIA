using UnityEngine;
using System.Collections;

public class HealthUp : MonoBehaviour {

    private HealthBar Plus;//instance of healthBar
	public AudioSource HealthClip;// AudioSource
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Plus = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthBar>();
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
			HealthClip.Play ();//Plays Clip
            this.gameObject.SetActive(false);// set object to inActive
            Plus.health +=25;// increase health value by 25
        }
        
    }
    
}
