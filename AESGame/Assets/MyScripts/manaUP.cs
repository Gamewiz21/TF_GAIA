using UnityEngine;
using System.Collections;

public class manaUP : MonoBehaviour {

    private Fireballshoot Plus;//instance of healthBar
    public AudioSource MagicClip;// AudioSource
    bool GotMagic;
    public GameObject Message;
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
            GotMagic = true;
            MagicClip.Play();//Plays Clip
            this.gameObject.SetActive(false);// set object to inActive
            Plus.FireAmmo += 25;// increase health value by 25
        }
        else
        {
            GotMagic = false;// if you didn't receievd magic
            Message.SetActive(false);// don't show message
        }

        if (GotMagic)// if you did get magic
        {
            Message.SetActive(true);// show message
            Destroy(Message, 1f);// destroy after 1 second
        }

    }
}
