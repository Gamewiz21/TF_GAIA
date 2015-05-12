using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour {
	public GUISkin MyGUISkin;// GUI SKin
	public Texture2D Background;// Background texu


	
	// Update is called once per frame
	private void OnGUI () {
		// if Background is not null, meaning nothing there show this, JUST CHECKING
		if (Background != null)
		{
			GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Background);// show texture
		}
	
	}

	void Update()
	{
		if (Input.GetKey (KeyCode.D))// when D is pressed
		{
			Application.LoadLevel("PickUps");// go to this scene
		}
	}
}
