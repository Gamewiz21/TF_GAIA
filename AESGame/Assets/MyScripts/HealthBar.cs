using UnityEngine;
using System.Collections;

public class HealthBar : HealthManager {// inherits from healthManager script
	//HuD GUI
    public GUIStyle HUD;
	public bool isDead = false;
	public AudioClip DeathClip;// class of AudioClip
	AudioSource audioSource;//instance of AudioSource
	//public AudioClip audioClip;
    protected override void Start()
    {
        base.Start();

     }
	
	// Update is called once per frame
	void Update () {
		audioSource = this.gameObject.GetComponent<AudioSource>();// get the component of AudioSource
      
		// if health equals 0
        if(health <= 0)
        {	// value of Lives decrments

			//plays Clip
			audioSource.PlayOneShot(DeathClip);

			isDead = true;

        }

	
	}

    void OnGUI()
    {	// display the health value as a GUI on the HUD
        GUI.Label(new Rect(10, 30, 300, 150), "Health: " + health,HUD);




    }

    void OnTriggerEnter2D(Collider2D other)
    {	// if Player comes in contact with "Spikes"
        if (other.gameObject.tag == "Spike")
        {	//lose 10 health
            health -= 10;
        }
		// if Player comes in contact with "void"
        if (other.gameObject.tag == "Void")
        {	//lose all health
            health -= 100;
          
        }
    }
}
