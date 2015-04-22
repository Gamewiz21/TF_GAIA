using UnityEngine;
using System.Collections;

public class SlashAttack : MonoBehaviour {

	Animator Anim;// instance of anamiation

	// Use this for initialization
	void Awake () {

		Anim = GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void Update () {
		// if O button is pressed
        if (Input.GetKeyDown(KeyCode.O))
            Anim.Play("Swords");//play anim

			
	
	}
}
