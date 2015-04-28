using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour {
	public GUISkin MyGUISkin;
	public Texture2D Background;


	
	// Update is called once per frame
	private void OnGUI () {
		// if Background is not null, meaning nothing there show this, JUST CHECKING
		if (Background != null)
		{
			GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Background);
		}
	
	}

	void Update()
	{
		if (Input.GetKey (KeyCode.RightArrow))
		{
			Application.LoadLevel("PickUps");
		}
	}
}
