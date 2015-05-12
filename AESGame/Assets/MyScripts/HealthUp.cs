using UnityEngine;
using System.Collections;

public class HealthUp : MonoBehaviour {
    public Texture2D Logo;
    private HealthBar Plus;//instance of healthBar
	public AudioSource HealthClip;// AudioSource
    public GameObject MedPak;
    bool Gothealth;
    public GameObject Message;
	// Use this for initialization
	void Start () {
        Message.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        Plus = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthBar>();
        
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        //Vector2 PakSpace = MedPak.transform.position;
        if (other.gameObject.tag == "Player")
        {
            Gothealth = true;
            HealthClip.Play();//Plays Clip
            this.gameObject.SetActive(false);// set object to inActive
            Plus.health += 25;// increase health value by 25
            //GUI.DrawTexture(new Rect(PakSpace.transform.position), Logo);
        }
        else 
        {
            Gothealth = false;// if player didn't get health
            Message.SetActive(false);// don't show message
        }

        if (Gothealth)// if player got health
        {
            Message.SetActive(true);// show message
            Destroy(Message, 1f);// destroy after 1 second
        }
        
    }
    
}
