using UnityEngine;
using System.Collections;

public class FireballSfx : MonoBehaviour
{

    public AudioSource Blast;//instance of AudioSource
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.P))// if o is pressed
        {
            if (!Blast.isPlaying)//if not already playing
                Blast.Play();// play Clip
        }

    }
}
