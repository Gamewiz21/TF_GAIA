using UnityEngine;
using System.Collections;

public class manaUP : MonoBehaviour {

    private Fireballshoot Plus;//instance of healthBar
    public AudioSource MagicClip;// AudioSource
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Plus = GameObject.Find("Hand").GetComponent<Fireballshoot>();// get component from fireball shoot script

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            MagicClip.Play();//Plays Clip
            this.gameObject.SetActive(false);// set object to inActive
            Plus.FireAmmo += 25;// increase health value by 25
        }

    }
}
